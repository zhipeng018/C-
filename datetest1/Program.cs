using System;

//字面意思：正在使用XXXX命名空间
//引入命名空间


//定义命名空间【类的住址】：对类进行逻辑上的划分，避免重名

namespace day01
{
    //定义类【做工具】

    class Program
    {
        //定义方法【做功能】
        //程序的入口方法

        static void Main2(string[] args)
        {
            //快捷键Command + A全选 Command + K + F自动对齐 Conmand + K + U取消注释
            
            //*********语句*********//

            Console.Title = "我的第一个程序";

            Console.WriteLine("输入您的姓名：");
            string name = Console.ReadLine();

            Console.WriteLine("您好：" + name);
            Console.ReadLine();

            //Console 是类【工具】
            //Writeline/ReadLine 是方法【动词的功能】
            //Title是属性【名词的修饰
            //类。方法（） 调用语句【使用某个类中的功能】


            //声明：在内存中开辟空间
            string gunName;
            //赋值：在该空间存储数据
            gunName = "ak47";

            //声明+赋值
            int age = 18;

            //同一范围，变量不能重复声明
            //string gunName;
            //变量可以重复赋值
            gunName = "MP5";
            //变量在使用前必须赋值
            Console.WriteLine(age);


            

        }

        static void Main1()
        {
            //调试：排除错误的能力
            //1.在可能出错的行 加断点
            //2.按F5 启动调试
            //3.按F10 逐语句进行
            //4.按左上小方块停止调试

            float num01 = 1.0f;
            float num02 = 0.9f;
            float result = num01 - num02;
            bool b1 = result == 0.1f;
            Console.WriteLine(b1);//flase

            //浮点型运算会出现舍入误差 --flase
            //二进制无法精确表示1/10，就像十进制无法精确表示1/3

            //decimal num01 = 3.0M;
            //decimal num02 = 2.9M;
            //decimal result = num01 - num02;
            //bool b1 = result == 0.1m;
            //Console.WriteLine(b1);//ture

            //sadaa

            
        }

        static void Main()
        {
            //练习：
            //在控制台中，录入枪的信息
            //“请输入枪的名称：”
            //“请输入弹匣容量：”
            //“请输入当前弹匣内子弹数量：”
            //“请输入剩余子弹数量：”

            //在一行显示：
            //枪的名称是：xxx，弹匣容量：xxx，弹匣内子弹数量：xxx，剩余子弹数量：xxx
            //hint：Console.ReadLine()里只能用string 否则会报错
            Console.WriteLine("请输入枪的名称：");
            string gunName = Console.ReadLine();
            Console.WriteLine("请输入弹匣容量：");
            string magazineCapacity = Console.ReadLine();
            Console.WriteLine("请输入当前弹匣内子弹数量：");
            string bulletCount = Console.ReadLine();
            Console.WriteLine("请输入剩余子弹数量");
            string bullets = Console.ReadLine();
            Console.WriteLine("枪的名称是：" +gunName+"弹匣容量："+magazineCapacity +"弹匣内子弹数量：" +bulletCount +"剩余子弹数量：" +bullets);

            //整形         非整形       非数值
            //int          float     char(只能存一个) string（可以存多个）bool（只能存true false）

            int n1 = 1;
            float n2 = 1.0f;
            char c1 = '1';
            string s1 = "1";
            bool b = true;
            b = false;
            b = 1 > 2;
        }  
    }
}
