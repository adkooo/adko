package main

import "fmt"

func main() {

	// تعریف یک متغیر عدد صحیح به نام 'a' و مقداردهی اولیه به عدد 5
	a := 5

	// استفاده از ساختار کنترلی 'switch' برای بررسی مقدار متغیر 'a'
	switch a {
	// اگر مقدار 'a' برابر با 5 باشد، این بخش اجرا می‌شود
	case 5:
		fmt.Println("Case 5 executed")
	// اگر مقدار 'a' برابر با 2 باشد، مقدار 'a' یک واحد افزایش یافته و پیام مربوطه چاپ می‌شود
	case 2:
		a += 1
		fmt.Println("Case 2 executed, new value of a:", a)
	// اگر مقدار 'a' برابر با 6 باشد، دستور fallthrough باعث می‌شود اجرای کنترل به مورد بعدی منتقل شود
	case 6:
		fallthrough // ادامه اجرای شرط بعدی (در صورت وجود)
	// اگر هیچ‌کدام از موارد قبلی مطابقت نکند، این بخش اجرا می‌شود
	default:
		fmt.Println("Default case executed")
	}
}
