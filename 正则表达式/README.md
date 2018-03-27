#### 常用工具
1. VS中插件中心中有比较多的正则表达式的操作插件
比如：Regular Expression Tester Extension
    简单使用：右键代码编辑器，或者使用快捷键就会弹出操作窗体，按照说明进行操作即可。
2. 学习的三个途径：
    1. 安装插件 Regular Expression Tester Extension
    2. 使用C#自带的类 using System.Text.RegularExpressions;
    3. 使用网络在线工具
#### 基本语法
1. 直接匹配
abc --> 直接匹配abc
2. 字符串匹配字符串
```
    Regular Expression: abc
    Text to match: eabcd
    Matches: [abc]
```
3. 数字匹配字符串 
```
    Regular Expression: abc
    Text to match: eabcd （abc）
```
4. \d（数字）
```
    Regular Expression: \d
    Text to match:  abcd123
    Matches: [1][2][3]
```
5. .（表示任何字符）
```
    Regular Expression: .
    Text to match: abcd123
    Matches: [a][b][c][d][1][2][3]
```
6. \. （匹配“.”这个字符）
```
    Regular Expression: \.
    Text to match: eabcd.
    Matches: [.]
```
7. [abc](匹配其中的每一个字符,匹配a或者b或者c)
```
    Regular Expression: [abc]
    Text to match: eabcd 
    Matches: [a][b][c]
```
8. c{2}(重复两次才匹配)
```
    Regular Expression: c{2}
    Text to match: eabccd
    Matches:  [cc]
```
9. c{2,3}(最少重复2次，最多重复3次)
```
    Regular Expression: c{2,3}
    Text to match: eabccdcccdc
    Matches: [cc][ccc]
```
10. c*(匹配0个c或多个c)
```
    Regular Expression: c*
    Text to match: ad132
    Matches:   []a[]b[]d[]1[]3[]2
```
11. c+(至少有一次或是多次，与*不同的是，不能匹配0个c)
```
    Regular Expression: c+
    Text to match: abcdcccecc
    Matches:  [c][ccc][cc]
```
12. c?(要么有c要么没有)
```
    Regular Expression: c?
    Text to match: abcdcc
    Matches: []a[]b[c]d[cc]  
```
13. \s（匹配空白）
```
    Regular Expression: \s
    Text to match: Hello World 
    Matches:    Hello[]World[]
```
14. \S(匹配所有不是空格的地方)
```
    Regular Expression:  \S
    Text to match: Hello World
    Matches:    [H][e][l][l][o][W][o][r][l][d]
```
15. ^hello(以hello开头),orld$(以orld结尾)
```
    Regular Expression: ^Hello.*orld$
    Text to match: Hello World 
    Matches:    [Hello World]
```
16. (Hello).*(rld)（获取的写法，先把Hello给获取出来，中间的点星去匹配一下，并没有去获取，最后用一个(World)把World给获取出来）
```
    Regular Expression:  (Hello).*(rld)
    Text to match: Hello World 
    Matches:    [(<1>Hello) Wo[<2>rld]]
```
17. (.*)（获取所有的，点表示所有字符，星号表示0个或多个，这样把所有的都给获取出来了）
```
    Regular Expression: (.*)
    Text to match: Hello World 
    Matches:    [(<1>Hello World)[(<1>)]]
```
18. (Hello|rld)（获取Hello或者是rld，“|”表示或的情况，只要能匹配到当中一段就能被获取出来）
```
    Regular Expression: (Hello|rld)
    Text to match: Hello World 
    Matches:    [(<1>Hello)] Wo[(<1>rld)]
```
19. \w（表示所有的字符）
```
    Regular Expression: \w
    Text to match: Hello World 
    Matches:    [H][e][l][l][o] [W][o][r][l][d]
```
20. \W（匹配除了单个的字符之外的东西，包括空格、特殊字符等）
```
    Regular Expression: \W
    Text to match: Hello World %^&&
    Matches:   Hello[]World[][%][^][&][&]
```
#### C#的Regex类
1. 常见的使用方式：
    1. 使用类的静态方法：Match/IsMatch/Replace，这样正则表达式的一些操作（匹配、过滤、获取等）都可以通过这个类下面的静态方法来实现
        这样做有一个好处：C#中正则表达式的引擎，比如正则表达式的一个运算可以缓存这么一个正则表达式，这样下次用的时候性能就提高了很多。
    2. 实例化这个类来使用：
        1. 三种实例化传参方式：
            //（1）Regex r = new Regex(/*要匹配的正则表达式模式*/);
            //（2）Regex r = new Regex(/*要匹配的正则表达式模式*/,/*用于修改正则表达式的枚举值的按位组合*/);
            //（3）Regex r = new Regex(/*要匹配的正则表达式模式*/,/*用于修改正则表达式的枚举值的按位组合*/,/*匹配的超时时间*/);
2. 具体能做什么：
    1. 判断一个字符串是否符合匹配一个正则表达式