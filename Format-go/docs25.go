package main

import "fmt"

// تعریف ساختار Person با چهار فیلد:
// - name از نوع string
// - age از نوع int
// - job از نوع string
// - salary از نوع int
type Person struct {
	name   string
	age    int
	job    string
	salary int
}

func main() {
	// تعریف دو متغیر از نوع Person
	var pers1 Person
	var pers2 Person

	// مشخصات pers1 (اولین شخص)
	pers1.name = "Hege"
	pers1.age = 45
	pers1.job = "Teacher"
	pers1.salary = 6000

	// مشخصات pers2 (دومین شخص)
	pers2.name = "Cecilie"
	pers2.age = 24
	pers2.job = "Marketing"
	pers2.salary = 4500

	// دسترسی به ویژگی‌های pers1 و چاپ اطلاعات آن
	fmt.Println("Name: ", pers1.name)   // چاپ نام pers1
	fmt.Println("Age: ", pers1.age)     // چاپ سن pers1
	fmt.Println("Job: ", pers1.job)     // چاپ شغل pers1
	fmt.Println("Salary: ", pers1.salary) // چاپ حقوق pers1

	// دسترسی به ویژگی‌های pers2 و چاپ اطلاعات آن
	fmt.Println("Name: ", pers2.name)   // چاپ نام pers2
	fmt.Println("Age: ", pers2.age)     // چاپ سن pers2
	fmt.Println("Job: ", pers2.job)     // چاپ شغل pers2
	fmt.Println("Salary: ", pers2.salary) // چاپ حقوق pers2
}
