package main

import "fmt"

func main() {

	// چاپ پیغام "Hello World!" به کنسول
	fmt.Println("Hello World!")

	// فراخوانی تابع Hi بدون پارامتر
	Hi()

	// فراخوانی تابع Hi1 که یک رشته ("Hi") باز می‌گرداند
	// چاپ نتیجه بازگشتی تابع Hi1
	print(Hi1())

	// فراخوانی تابع Hi3 که یک رشته به عنوان پارامتر می‌گیرد و "Hi" را به آن اضافه می‌کند
	// چاپ نتیجه بازگشتی تابع Hi3 با پارامتر "Hi"
	print(Hi3("Hi"))
}

// تابع Hi که هیچ پارامتری ندارد و فقط کلمه "Hi" را چاپ می‌کند
func Hi() {
	// چاپ "Hi" به کنسول
	print("Hi")
}

// تابع Hi1 که یک مقدار از نوع string باز می‌گرداند
// این تابع رشته "Hi" را به عنوان خروجی باز می‌گرداند
func Hi1() string {
	// بازگرداندن رشته "Hi"
	return "Hi"
}

// تابع Hi3 که یک پارامتر از نوع string به نام a می‌گیرد
// و رشته "ali" را به پارامتر ورودی اضافه می‌کند
func Hi3(a string) string {
	// بازگرداندن ترکیب رشته ورودی با "ali"
	return a + "ali"
}
