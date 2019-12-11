using System;


/// <summary>
/// 斐波那契数列
/// </summary>
namespace Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 有一对兔子，从出生后第 3 个月起每个月都生一对兔子，小兔子长到第三个月后每个月又生一对兔子，假如兔子都不死，问每个月的兔子总数为多少？	
            //int Num = 20;
            //int[] arrayList = new int[Num];
            ////一月 二月的兔子都为1
            ////so
            //arrayList[0] = 1;
            //arrayList[1] = 1;
            ////从第二个月开始 
            //for (int i = 2; i < Num; i++)
            //{
            //    arrayList[i] = arrayList[i - 2] + arrayList[i - 1];
            //}
            //for (int i = 0; i < arrayList.Length; i++)
            //{
            //    Console.WriteLine("第" + i + "个月的兔子是" + arrayList[i]);
            //}
            #endregion

            #region  题目
            //父亲准备为小龙的四年大学生活一次性储蓄一笔钱 使用整存零取的方式，控制小龙每*** 底取1000元准备下月使用（到第48个月取1000元 后刚好余额为0）。 假设银行一年整存零取的年息为1.71 %，请算出父亲至少需要存入多少钱才行。


            //int num = 48;
            //int Money = 1000;
            //float moneyrate = 0.0171f;
            //float[] arrayList = new float[num];
            //arrayList[0] = Money;
            //for (int i = 1; i < num; i++)
            //{
            //    arrayList[i] =  ((arrayList[i-1] + Money) / (1 + moneyrate / 12));
            //}
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("第" + ( num-i) + "个月 钱等于" + arrayList[i]);
            //}
            #endregion

            Console.WriteLine(JieCheng(6));
            
            Console.ReadKey();
        }

        static int JieCheng(int n)
        {
            if (n<=1)
            {
                return 1;
            }else
            {
                return n * JieCheng(n-1);
            }

        }
    }
}
