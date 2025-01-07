package main

import (
	"fmt"
	"strings"
)

func main() {

	a := "h ui"

	// بررسی می‌کند آیا رشته شامل کاراکتر "h" هست یا خیر
	fmt.Println("Contains 'h':", strings.Contains(a, "h"))

	// بررسی می‌کند آیا هر یک از کاراکترهای "h" در رشته موجود است یا خیر
	fmt.Println("ContainsAny 'h':", strings.ContainsAny(a, "h"))

	// رشته را بر اساس اولین حضور کاراکتر "h" جدا می‌کند
	fmt.Println("Cut by 'h':", strings.Cut(a, "h"))

	// تعداد حضور کاراکتر "h" در رشته را برمی‌گرداند
	fmt.Println("Count 'h':", strings.Count(a, "h"))

	// تقسیم رشته بر اساس فاصله و بازگرداندن آرایه‌ای از بخش‌ها
	fmt.Println("Split by space:", strings.Split(a, " "))

	// طول رشته را چاپ می‌کند
	fmt.Println("Length of string:", len(a))

	// تکرار رشته "ali" به تعداد 10 بار
	fmt.Println("Repeat 'ali' 10 times:", strings.Repeat("ali", 10))

	// جایگزینی اولین 3 مورد از "h" با "ali"
	fmt.Println("Replace 'h' with 'ali' (limit 3):", strings.Replace(a, "h", "ali", 3))

	// جایگزینی تمام موارد "h" با "ali"
	fmt.Println("ReplaceAll 'h' with 'ali':", strings.ReplaceAll(a, "h", "ali"))

	// مقایسه رشته "h" و "ali" (lexicographical comparison)
	fmt.Println("Compare 'h' and 'ali':", strings.Compare("h", "ali"))

	// بررسی برابری بدون توجه به بزرگی و کوچکی حروف
	fmt.Println("EqualFold 'h' and 'ali':", strings.EqualFold("h", "ali"))

	// بررسی پیشوند بودن "ali" برای رشته "h"
	fmt.Println("HasPrefix 'h' and 'ali':", strings.HasPrefix("h", "ali"))

	// بررسی پسوند بودن "ali" برای رشته "h"
	fmt.Println("HasSuffix 'h' and 'ali':", strings.HasSuffix("h", "ali"))

	// یافتن اولین موقعیت حضور "ali" در رشته "h"
	fmt.Println("Index of 'ali' in 'h':", strings.Index("h", "ali"))

	// تبدیل رشته به حروف کوچک
	fmt.Println("ToLower 'ali':", strings.ToLower("ali"))

	// تبدیل اولین حرف هر کلمه به حرف بزرگ
	fmt.Println("Title 'ali':", strings.Title("ali"))

	// تبدیل رشته به حروف بزرگ
	fmt.Println("ToUpper 'ali':", strings.ToUpper("ali"))

	// حذف کاراکترهای "ali" از ابتدا و انتهای رشته "h"
	fmt.Println("Trim 'h' by 'ali':", strings.Trim("h", "ali"))

	// حذف کاراکترهای "ali" از ابتدای رشته "h"
	fmt.Println("TrimLeft 'h' by 'ali':", strings.TrimLeft("h", "ali"))

	// حذف کاراکترهای "ali" از انتهای رشته "h"
	fmt.Println("TrimRight 'h' by 'ali':", strings.TrimRight("h", "ali"))
}
