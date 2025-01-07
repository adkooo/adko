// محدوده دید یا اسگوپ

package main

import "fmt"

// تعریف متغیر a در محدوده جهانی (global scope)
var a = 123

func main() {

	// شروع یک بلوک جدید که محدوده دید خاص خود را دارد
	{
		// متغیر b فقط در این بلوک قابل دسترسی است
		b := 4
		fmt.Println("Debug: Value of b inside block:", b) // چاپ مقدار b برای دیباگ
	}
	
	// چاپ مقدار a که در محدوده جهانی تعریف شده است
	fmt.Println("Debug: Value of global variable a:", a)

	// تست توابع مختلف چاپ رشته‌ها
	print("Debug: Using print function\n")
	println("Debug: Using println function")
	fmt.Printf("Debug: Using fmt.Printf\n")
}
