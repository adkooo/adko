package main

import "fmt"

func main() {

	// تعریف یک متغیر رشته‌ای برای دریافت ورودی
	var a string

	// چاپ پیام برای درخواست ورودی از کاربر
	fmt.Println("عدد را وارد کنید")

	// دریافت ورودی و ذخیره آن در متغیر a
	fmt.Scanln(&a)

	// بررسی مقدار ورودی با استفاده از switch
	switch a {
	case "1":
		fmt.Println("یک")
	case "2":
		fmt.Println("دو")
	default:
		fmt.Println("Hi")
	}
}
