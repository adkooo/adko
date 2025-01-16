using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Sprite[] walkLeftSprites;
    public Sprite[] walkRightSprites;
    public Sprite[] walkUpSprites;
    public Sprite[] idleSprites;

    public float frameRate = 0.1f;      // نرخ تغییر فریم‌ها
    public float moveSpeed = 5.0f;      // سرعت حرکت
    public float bobHeight = 0.2f;      // میزان بالا رفتن
    public float bobUpSpeed = 2.0f;     // سرعت بالا رفتن
    public float bobDownSpeed = 5.0f;   // سرعت بازگشت به پایین

    private SpriteRenderer spriteRenderer;
    private int currentFrame = 0;
    private bool isMoving = false;
    private Vector3 lastDirection = Vector3.zero;
    private Sprite[] currentSprites;
    private Coroutine animationCoroutine;
    private bool isCoroutineRunning = false;

    private Vector3 initialPosition;
    private Rigidbody2D rb;

    public Camera mainCamera;          // دوربین اصلی
    public Vector3 cameraOffset = new Vector3(0, 2, -10); // فاصله دوربین
    public float cameraSmoothSpeed = 0.125f; // سرعت نرم دوربین

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentSprites = idleSprites;
        initialPosition = transform.position; // موقعیت اولیه ذخیره شود
        rb = GetComponent<Rigidbody2D>();

        // قفل کردن چرخش در محور Z
        rb.freezeRotation = true;

        // غیرفعال کردن گرانش برای ثابت ماندن شخصیت
        rb.gravityScale = 0;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // غیرفعال کردن حرکت به پایین
        if (vertical < 0)
        {
            vertical = 0;
        }

        Vector3 moveDirection = new Vector3(horizontal, vertical, 0);

        // اعمال حرکت با Rigidbody2D (فقط در محور X)
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, rb.velocity.y);

        // تغییر جهت برای حرکت افقی
        if (horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1); // به سمت راست
        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1); // به سمت چپ
        }

        // اگر حرکت به سمت بالا باشد، ارتفاع را تنظیم کن
        if (vertical > 0)
        {
            float newY = Mathf.Lerp(transform.position.y, initialPosition.y + bobHeight, Time.deltaTime * bobUpSpeed);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }
        // اگر حرکت به بالا متوقف شد، سریع‌تر به پایین بازگردد
        else if (vertical == 0)
        {
            float newY = Mathf.Lerp(transform.position.y, initialPosition.y, Time.deltaTime * bobDownSpeed);
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

        // کنترل تغییر انیمیشن
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

    // انتخاب اسپرایت مناسب براساس جهت حرکت
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

    // اجرای انیمیشن فریم به فریم
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
