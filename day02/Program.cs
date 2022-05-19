using System;

namespace day02
{
    class Program
    {
        //占位符 转义符
        static void Main1(string[] args)
        {
            string gunName = "AK47";
            string ammoCapacity = "30";
            //ijd
            //在字符串中插入变量
            Console.WriteLine("枪的名称为：" + gunName + "，容量为：" + ammoCapacity);
            //占位符{数字（位置的编号）}如果编号大于参数列表长度 则异常
            string str =
                string .Format("枪的名称为：{0}，容量为：{1}.",gunName,ammoCapacity);
            Console.WriteLine(str);
            //

            //标准数字字符串格式化   
            Console.WriteLine("金额:{0:c}",10);//货币 10.00$
            Console.WriteLine("{0:d2}",5);//05 不足2位用0填充
            Console.WriteLine("{0:f1}",1.26);//1.3 根据指定精度显示 带四舍五入
            Console.WriteLine("{0:p0}",0.1);//10% 以百分数显示

            //转义符：改变字符原始含义 \"
            Console.WriteLine("我爱\"unity!\""); //我爱“unity！”
            char c1= '\''; // '
            char c2 = '\0';//空字符 ''

            // \r\n回车换行  \t 水平制表格
            Console.WriteLine("你好，\r\n我是隔壁的\t老王。");

            //源代码（.cs的文本文件）——CLS编译——通用中间语言——CLR编译——机器码 0 1
            //                    目的：跨语言          目的：优化 跨平台 


        }

        //运算符
        static void Main2()
        {
            //1 赋值运算符
            int n1 = 5, n2 = 2;

            //2 算数运算符：对数字做算术运算
            int r1 = n1 + n2; //5+2
            int r2 = n1 / n2; //5/2 ==> 2.5 截断删除 2
            int r3 = n1 % n2; //n1 mod n2 取模（余数）1
            //%的作用：
            //1. 判断一个数字能否被另外一个数字整除
            //n1 是否能被2 整除 true 是偶数  false 是奇数
            bool r4 = n1 % 2 == 0;
            //2.获取数字的个位
            int r5 = n1 % 10;

            string s1 = "5", s2 = "2";
            string r6 = s1 + s2;  //52 字符的拼接

            //3 比较运算符 > <  >= <= 等于 == 不等于!=
            bool r7 = n1 > n2;
            bool r8 = s1 == s2; //文本是否相同


            //4 逻辑运算符 && || ! 判断bool值关系的符号
            bool r9 = true && true;//真 与 真 结果：真
            r9 = true && false;//真 与 假 结果：假
            r9 = false && true;//假 与 真 结果：假
            r9 = false && false;//假 与 假 结果：真
            //总结：一假则假 表达 并且 的关系

            bool r10 = true || true;//真 或 真 结果：真
            r10 = true || false;//真 或 假 结果：假
            r10 = false || true;//假 或 真 结果：假
            r10 = false || false;//假 或 假 结果：真
            //总结： 一真则真 表达 或者 的关系

            //如果玩家到了最左边 && 还想向左移动
            //              ||
            //如果玩家到了最右边 && 还想向右移动
            // 停

            bool r11 = !true; //取反 false

            //5.快捷运算符 += *= /= %=
            int num01 = 1;
            num01 = num01 + 5;//一个变量num01 加上另外一个数 再赋值给自身
            num01 += 5;
            Console.WriteLine(num01);//6

            //6.一元运算符 ++ --   二元   三元
            //根据操作数划分


            //(1)无论先加 还是后加 对于「下一条指令」，都是自增以后的值
            int number01 = 1;
            number01++;
            Console.WriteLine(number01);//2

            int number02 = 1;
            ++number02;
            Console.WriteLine(number02);//2

            //(2)后加 --》 后自增 --》 先返回值
            int number03 = 1;
            Console.WriteLine(number03++);//1 结果：自增以前
            Console.WriteLine(number03);//2
            // 先加 --》 先自增 --》 后返回值
            int number04 = 1;
            Console.WriteLine(++number04);//2 结果：自增以后
            Console.WriteLine(number04);//2

            //7.三元运算符 数据类信号 变量名= 条件 ? 满足条件结果结果 :不满足条件结果结果；
            string str01 = 1 > 2 ? "ok" : "no";
            float r12 = 1 == 1 ? 1.2f : 1.5f;

            //8.优先级 先乘除 后加减 小括号优先级最高
            int r13 = 1 + 2 * 4;
        }

        //数据类型转换
        static void Main3()
        {
            //数据类型转换
            //string "18" ==》 int 18

            //1.Parse转换 ：string 转换为其他数据类型
            //待转数据 必须 “像” 该数据类型
            string strNumber = "18";
            int num01 = int.Parse(strNumber);//18
            float num02 = float.Parse(strNumber);//18.0

            //2.Tostring转换：任意类型转换为string类型
            int number = 18;
            string str=number.ToString();

            //3.隐式转换：由小范围 到 大范围 自动转换
            byte b3 = 100;
            int i3 = b3;

            //4.显式转换：由大范围 到 小范围 强制转换
            //备注：有可能发生精度的丢失
            int i4 = 100;
            byte b4 = (byte)i4;

            //当表达式由多种变量参与运算 结果自动向较大的类型提升
            byte num1 = 1;
            byte num2 = 2;
            //short result = (short)(num1 + num2);
            //int result = num1 + num2;


            int a = 1;
            a = a + 3;
            a += 3;

            byte b = 1;
            b += 3;
            b = (byte)(b + 3);
        }

        //练习
        static void Main4()
        {
            //练习；让用户在控制台中输入一个4位整数
            //计算每位相加和
            //例如 1234==》 1+2+3+4 ==》10
            //方案1； 从整数中获取每位
            //方案2:从字符串中获取每个字符
            //string str02 = "1234";
            //char c1 = str02[0];// '1' --> "1" --> 1

            
            #region 方案1
            Console.WriteLine("numbers");
            string number = Console.ReadLine();

            int num = int.Parse(number);
            int n1 = num % 10;
            int n2 = num % 100 / 10;
            int n3 = num % 1000 / 100;
            int n4 = num % 10000 / 1000;

            int n5 = n1 + n2 + n3 + n4;
            Console.WriteLine(n5);
            #endregion

            #region 方案2
            Console.WriteLine("请输入数字");
            string strNumber = Console.ReadLine();

            int number1 = int.Parse(strNumber);
            int result = number1 % 10;
            result += number1 / 10 % 10;
            result += number1 / 100 % 10;
            result += number1 / 1000;

            Console.WriteLine("结果位：" + result);
            #endregion

            #region 方案3
            Console.WriteLine("请输入数字");
            string number2 = Console.ReadLine();
            char c1 = number[0], c2 = number[1], c3 = number[2], c4 = number[3];
            string str1 = c1.ToString();
            string str2 = c2.ToString();
            string str3 = c3.ToString();
            string str4 = c4.ToString();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);
            int num3 = int.Parse(str3);
            int num4 = int.Parse(str4);

            int num5 = num1 + num2 + num3 + num4;

            Console.WriteLine(num5);

            #endregion


            //char c1 = strNumber[0];
            //string s1 = c1.toString();
            //int n1=int.Parse(s1);
            // =
            //int result02 = n1;
            //result02 += int.Parse(strNumber[0].ToString());

        }


        static void Main()
        {


        }
    }
}

