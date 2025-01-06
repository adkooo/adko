package main

import "fmt"  // وارد کردن بسته fmt برای استفاده از توابع ورودی/خروجی

func main() {

	// تعریف و مقداردهی متغیرها به شیوه‌های مختلف

	var a string = "ali"  // تعریف متغیر a از نوع string و مقداردهی آن به "ali"
	// در اینجا نوع متغیر string مشخص است و مقدار آن به صورت دستی به "ali" داده شده است.

	var b int = 12  // تعریف متغیر b از نوع int و مقداردهی آن به 12
	// نوع متغیر int است و مقدار آن به صورت دستی به 12 داده شده است.

	var c float32  // تعریف متغیر c از نوع float32 بدون مقداردهی اولیه
	// در اینجا، متغیر c تعریف شده ولی هیچ مقداری به آن داده نشده است. بنابراین مقدار پیش‌فرض آن 0 است.

	var d = "all"  // تعریف متغیر d با استفاده از شورت‌کت (نوع داده به طور خودکار تشخیص داده می‌شود)
	// نوع داده‌ی d به طور خودکار از مقدار آن (در اینجا "all") به string تشخیص داده می‌شود.

	e := 44  // تعریف و مقداردهی متغیر e با استفاده از شورت‌کت، نوع آن به طور خودکار int تشخیص داده می‌شود
	// در اینجا از علامت `:=` برای تعریف و مقداردهی استفاده شده که نوع داده از مقدار 44 به طور خودکار int تشخیص داده می‌شود.

	var m, f, j = 9, 12, "iran"  // تعریف و مقداردهی چندین متغیر به طور همزمان
	// در اینجا چندین متغیر به طور همزمان تعریف و مقداردهی می‌شوند: 
	// m به 9 (int)، f به 12 (int) و j به "iran" (string) مقداردهی می‌شوند.

	var (  // تعریف چندین متغیر در یک بلاک
		y = 8  // متغیر y به 8 مقداردهی می‌شود
		h = "no"  // متغیر h به "no" مقداردهی می‌شود
	)
	// در اینجا دو متغیر (y و h) در یک بلاک تعریف و مقداردهی شده‌اند.

	// چاپ مقادیر متغیرها
	fmt.Println(a, b, c, d, e, m, f, j, y, h)
	// در اینجا تمام مقادیر متغیرها به ترتیب چاپ می‌شود.
	// این تابع مقادیر متغیرهای a, b, c, d, e, m, f, j, y و h را نمایش می‌دهد.
	// c که مقدار اولیه ندارد، مقدار پیش‌فرض آن 0 خواهد بود.
}
