package main

import (
    "fmt"
    "math/bits"
    "unsafe"
)

func main() {
    fmt.Println("Hello World!") // چاپ عبارت "Hello World!" در کنسول

    var a int = 5 // ایجاد یک متغیر از نوع int
    fmt.Printf("int %d \n", unsafe.Sizeof(a)) // نمایش اندازه متغیر a با استفاده از unsafe.Sizeof

    var b float32 = 12.2 // ایجاد یک متغیر از نوع float32
    fmt.Printf("int %d \n", unsafe.Sizeof(b)) // نمایش اندازه متغیر b با استفاده از unsafe.Sizeof
    
    var c = bits.UintSize // اندازه استاندارد نوع داده Uint در سیستم (32 یا 64)
    fmt.Println(c) // چاپ اندازه UintSize
}
