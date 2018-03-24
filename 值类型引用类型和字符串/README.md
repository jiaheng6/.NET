#### 什么是值类型，什么是引用类型？
1. 值类型均隐式派生自System.ValueType
    1. 数值类型、bool、结构、枚举、int、char、double、decimal、enum、。。。
    2. 正常情况下，所有值类型的值是存在栈上的
2. 引用类型派生自System.Object
    1. 字符串、数组、类、接口（是一种私有的抽象的类）等
    2. 值存储在堆中，地址存储在栈中。