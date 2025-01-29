using System.Collections;
using UnityEngine;

// این اسکریپت کنترل شخصیت دوبعدی را مدیریت می‌کند که شامل حرکت، انیمیشن و دنبال کردن دوربین است
public class NewBehaviourScript : MonoBehaviour
{
    // مجموعه اسپرایت‌های حرکت در جهات مختلف و حالت بی‌حرکت
    public Sprite[] walkLeftSprites;
    public Sprite[] walkRightSprites;
    public Sprite[] walkUpSprites;
    public Sprite[] idleSprites;

    // تنظیمات سرعت و حرکت
    public float frameRate = 0.1f;      // نرخ تغییر فریم‌ها
    public float moveSpeed = 5.0f;      // سرعت حرکت
    public float bobHeight = 0.2f;      // میزان بالا رفتن هنگام حرکت
    public float bobUpSpeed = 2.0f;     // سرعت بالا رفتن
    public float bobDownSpeed = 5.0f;   // سرعت بازگشت به پایین

    // متغیرهای داخلی مربوط به انیمیشن و فیزیک
    private SpriteRenderer spriteRenderer;
    private int currentFrame = 0;
    private bool isMoving = false;
    private Vector3 lastDirection = Vector3.zero;
    private Sprite[] currentSprites;
    private Coroutine animationCoroutine;
    private bool isCoroutineRunning = false;
    private Vector3 initialPosition;
    private Rigidbody2D rb;

    // متغیرهای مربوط به دوربین
    public Camera mainCamera;
    public Vector3 cameraOffset = new Vector3(0, 2, -10); // فاصله دوربین از شخصیت
    public float cameraSmoothSpeed = 0.125f; // سرعت حرکت نرم دوربین

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentSprites = idleSprites;
        initialPosition = transform.position; // ذخیره موقعیت اولیه
        rb = GetComponent<Rigidbody2D>();

        // جلوگیری از چرخش شخصیت در محور Z
        rb.freezeRotation = true;

        // غیرفعال کردن گرانش برای ثابت ماندن شخصیت در صفحه
        rb.gravityScale = 0;
    }

    void Update()
    {
        // دریافت ورودی‌های صفحه کلید
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // جلوگیری از حرکت به پایین
        if (vertical < 0)
        {
            vertical = 0;
        }

        Vector3 moveDirection = new Vector3(horizontal, vertical, 0);

        // اعمال حرکت با Rigidbody2D (فقط در محور X)
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

        // تغییر جهت اسپرایت هنگام حرکت به چپ و راست
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // جهت راست
        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // جهت چپ
        }

        // تنظیم ارتفاع شخصیت هنگام حرکت به بالا
        if (vertical > 0)
        {
            float newY = Mathf.Lerp(transform.position.y, initialPosition.y + bobHeight, Time.deltaTime * bobUpSpeed);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
        else if (vertical == 0) // بازگشت سریع‌تر به ارتفاع اولیه
        {
            float newY = Mathf.Lerp(transform.position.y, initialPosition.y, Time.deltaTime * bobDownSpeed);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

        // بررسی حرکت و تغییر انیمیشن مناسب
        if (moveDirection.magnitude > 0)
        {
            if (!isMoving || moveDirection != lastDirection)
            {
                lastDirection = moveDirection;
                isMoving = true;
                SelectSpriteArray(moveDirection);
                if (!isCoroutineRunning)
                {
                    isCoroutineRunning = true;
                    StartCoroutine(AnimateGhost());
                }
            }
        }
        else
        {
            if (isMoving)
            {
                isMoving = false;
                currentSprites = idleSprites;
                if (!isCoroutineRunning)
                {
                    isCoroutineRunning = true;
                    StartCoroutine(AnimateGhost());
                }
            }
        }

        // به‌روزرسانی موقعیت دوربین
        UpdateCameraPosition();
    }

    // انتخاب مجموعه اسپرایت مناسب بر اساس جهت حرکت
    void SelectSpriteArray(Vector3 moveDirection)
    {
        if (moveDirection.x < 0)
        {
            currentSprites = walkLeftSprites;
        }
        else if (moveDirection.x > 0)
        {
            currentSprites = walkRightSprites;
        }
        else if (moveDirection.y > 0)
        {
            currentSprites = walkUpSprites;
        }
    }

    // اجرای انیمیشن حرکت شخصیت به‌صورت فریم به فریم
    IEnumerator AnimateGhost()
    {
        while (isMoving || currentSprites == idleSprites)
        {
            spriteRenderer.sprite = currentSprites[currentFrame];
            currentFrame++;

            if (currentFrame >= currentSprites.Length)
            {
                currentFrame = 0;
            }

            yield return new WaitForSeconds(frameRate);
        }

        if (!isMoving)
        {
            currentFrame = 0;
            while (!isMoving)
            {
                spriteRenderer.sprite = idleSprites[currentFrame];
                yield return new WaitForSeconds(frameRate);
            }
        }
        isCoroutineRunning = false;
    }

    // حرکت دوربین با شخصیت
    void UpdateCameraPosition()
    {
        if (mainCamera != null)
        {
            Vector3 desiredPosition = transform.position + cameraOffset;
            Vector3 smoothedPosition = Vector3.Lerp(mainCamera.transform.position, desiredPosition, cameraSmoothSpeed);
            mainCamera.transform.position = smoothedPosition;
        }
    }
}
