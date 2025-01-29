package main

import (
	"fmt"
)

func main() {
	// تعریف یک متغیر به نام mysum که یک تابع بی‌نام (anonymous function) است
	// این تابع هیچ پارامتر ورودی ندارد و فقط پیغام "hi" را چاپ می‌کند
	mysum := func() {
		// چاپ "hi" به کنسول
		fmt.Printf("hi")
	}

	// فراخوانی تابع mysum
	// این تابع پیغام "hi" را چاپ می‌کند
	mysum()
}
