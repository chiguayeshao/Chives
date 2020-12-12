using System;
using System.Collections.Generic;

namespace Chives
{
    class Program
    {
        public static Model model = new Model();

        static void Main(string[] args)
        {
            //韭菜价格（以后使用爬虫获取）
            double currentPrice = 0;
            //投入金额
            double investAmount = 0;

            //将每次购买的个数存入list
            List<double> listCalCount = new List<double>();

            //将每次投入的金额存入list
            List<double> listInvestAmount = new List<double>();

            //是否结束割韭菜
            string stop = "";

            while (stop != "yes")
            {
                Console.WriteLine("请输入韭菜价格 please enter current chives price");
                currentPrice = Double.Parse(Console.ReadLine());
                Console.WriteLine("当前韭菜价格为 current chives price is：" + currentPrice);

                Console.WriteLine("请输入购买金额 please enter investAmount");
                investAmount = Double.Parse(Console.ReadLine());
                Console.WriteLine("购买金额为 investAmount is:" + investAmount);

                //将每次购买的个数存入list
                listCalCount.Add(model.CalCount(investAmount, currentPrice));
                //将每次投入的金额存入list
                listInvestAmount.Add(investAmount);

                Console.WriteLine("是否结束割韭菜? is stop cut chives ?：yes/no");
                stop = Console.ReadLine();
            }

            //卖出价位
            double sellPrice = 0;
            Console.WriteLine("请输入卖出价位 please enter sellPrice");
            sellPrice = Double.Parse(Console.ReadLine());

            //计算总个数
            double allCount;
            allCount = model.CalAllcount(listCalCount);

            //计算总共卖出的金额
            double allPrice;
            allPrice = model.CalAllPrice(allCount, sellPrice);

            //计算总投入金额
            double allInvestAmount;
            allInvestAmount = model.CalAllInvestAmount(listInvestAmount);

            //计算收益率
            double rate;
            rate = model.CalRate(allPrice, allInvestAmount);

            Console.WriteLine("割韭菜获得的收益率为 cut chives rate of return" + rate * 100 + "%");

            //Console.WriteLine(model.CalAllcount(listCalCount));

        }

    }
}
