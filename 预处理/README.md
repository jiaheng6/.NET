#### 预处理命令
1. 
```
    #define DEBUG
    #undef DEBUG
```
2. 编译器层级逻辑语句
``` 
    #if (DEBUG)
        Console.WriteLine("DEBUG");
    #else
        Console.WriteLine("Wrong");
    #endif
        Console.WriteLine("end if");
```
3. 代码块折叠
```
    #region   
    #endregion
```