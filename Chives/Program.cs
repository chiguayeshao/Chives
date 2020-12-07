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
            Console.WriteLine("请输入韭菜价格");
            currentPrice = Double.Parse(Console.ReadLine()); 
            Console.WriteLine("当前韭菜价格为：" + currentPrice);

            //投入金额
            double investAmount = 0;
            Console.WriteLine("请输入购买金额");
            investAmount = Double.Parse(Console.ReadLine());

            //卖出价位
            double sellPrice = 0;
            Console.WriteLine("请输入卖出价位");
            sellPrice = Double.Parse(Console.ReadLine());


            //将每次购买的存入list
            List<double> listCalCount = new List<double>();
            listCalCount.Add(model.CalCount(1000, 100));

            //将每次投入的金额存入list
            List<double> listInvestAmount = new List<double>();
            listInvestAmount.Add(investAmount);

            //计算总个数
            double allCount;
            allCount = model.CalAllcount(listCalCount);

            //计算总共卖出的金额
            double allPrice;
            allPrice = model.CalAllPrice(allCount , sellPrice);

            //计算总投入金额
            double allInvestAmount;
            allInvestAmount = model.CalAllInvestAmount(listInvestAmount);

            //计算收益率
            double rate;
            rate = model.CalRate(allPrice, allInvestAmount);

            Console.WriteLine("割韭菜获得的收益率为"+rate*100+"%");

            //Console.WriteLine(model.CalAllcount(listCalCount));

            //测试一下

        }

    }
}
