using System;
using System.Collections.Generic;
using System.Text;

namespace Chives
{
    class Model
    {
        //投入金额
        public double InvestAmount { get; set; }

        //总投入金额
        public double AllInvestAmount { get; set; }

        //当前价位
        public double CurrentPrice { get; set; }

        //获得个数
        public double Count { get; set; }

        //投入次数
        public int InvestCount { get; set; }

        //总个数
        public double AllCount { get; set; }

        //卖出价位
        public double SellPrice { get; set; }

        //卖出获得总金额
        public double AllPrice { get; set; }

        //收益率
        public double rate { get; set; }

        /// <summary>
        /// 计算当前个数
        /// </summary>
        /// <param name="investAmount">投入金额</param>
        /// <param name="currentPrice">当前价格</param> 以后应该使用爬虫获取
        /// <returns>当前获得个数</returns>
        public double CalCount(double investAmount , double currentPrice)
        {
            double count = investAmount / currentPrice;

            return count;
        }

        /// <summary>
        /// 计算总个数
        /// </summary>
        /// <param name="listCount">将每次获得的个数存入list</param>
        /// <returns>总个数</returns>
        public double CalAllcount( List<double> listCount)
        {
            double calAllcount = 0;
            foreach (var item in listCount)
            {
                calAllcount += item;
            }

            return calAllcount;
        }

        /// <summary>
        /// 计算卖出总金额
        /// </summary>
        /// <param name="allCount">总个数</param>
        /// <param name="sellPrice">每个卖出金额</param>
        /// <returns>卖出总金额</returns>
        public double CalAllPrice( double allCount , double sellPrice)
        {
            double AllPrice = allCount * sellPrice;
            return AllPrice;
        }

        /// <summary>
        /// 计算总投入金额
        /// </summary>
        /// <param name="listInvestAmount">将每次的买入金额存入list</param>
        /// <returns>总投入金额</returns>
        public double CalAllInvestAmount(List<double> listInvestAmount)
        {
            double allInvestAmount = 0;
            foreach (var item in listInvestAmount)
            {
                allInvestAmount += item;
            }
            return allInvestAmount;
        }

        /// <summary>
        /// 计算收益率
        /// </summary>
        /// <param name="allPrice">卖出获得的总金额</param>
        /// <param name="allInvestAmount">投入总金额</param>
        /// <returns>收益率</returns>
        public double CalRate(double allPrice , double allInvestAmount)
        {
            double rate = (allPrice- allInvestAmount) / allInvestAmount;
            return rate;
        }

        //测试一下
    }

}
