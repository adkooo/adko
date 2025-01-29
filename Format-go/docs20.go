package main

import "fmt"

func main() {

	// چاپ پیغام "Hello World!" به کنسول
	fmt.Println("Hello World!")

	// فراخوانی تابع printt با پارامتر "ali" و چاپ نتیجه بازگشتی آن
	// تابع printt یک رشته جدید با ترکیب "hi" و مقدار پارامتر ورودی باز می‌گرداند
	// نتیجه این تابع توسط fmt.Printf چاپ می‌شود
	fmt.Printf(printt("ali"))
}

// تابع printt که یک پارامتر از نوع string می‌گیرد
// و یک رشته ترکیب شده از "hi" و مقدار پارامتر ورودی را باز می‌گرداند
func printt(a string) string {
	// بازگرداندن ترکیب "hi" با رشته ورودی
	return "hi" + a
}
