using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var masterList = new List<MartialArtsMaster>
            {
                new MartialArtsMaster {ID = 1, Name = "黄蓉", Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法", Level = 9},
                new MartialArtsMaster {ID = 2, Name = "洪七公", Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法", Level = 10},
                new MartialArtsMaster {ID = 3, Name = "郭靖", Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌", Level = 10},
                new MartialArtsMaster {ID = 4, Name = "任我行", Age = 50, Menpai = "明教", Kongfu = "葵花宝典", Level = 1},
                new MartialArtsMaster {ID = 5, Name = "东方不败", Age = 35, Menpai = "明教", Kongfu = "葵花宝典", Level = 10},
                new MartialArtsMaster {ID = 6, Name = "林平之", Age = 23, Menpai = "华山", Kongfu = "葵花宝典", Level = 7},
                new MartialArtsMaster {ID = 7, Name = "岳不群", Age = 50, Menpai = "华山", Kongfu = "葵花宝典", Level = 8},
                new MartialArtsMaster {ID = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10},
                new MartialArtsMaster {ID = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8},
                new MartialArtsMaster {ID = 10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10},
                new MartialArtsMaster {ID = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10}
            };


            //初始化武学
            var kongfuList = new List<Kongfu>
            {
                new Kongfu {ID = 1, Name = "打狗棒法",  Power= 90},
                new Kongfu {ID = 2, Name = "降龙十八掌",Power = 95},
                new Kongfu {ID = 3, Name = "葵花宝典", Power = 100},
                new Kongfu {ID = 4, Name = "独孤九剑", Power = 100},
                new Kongfu {ID = 5, Name = "九阴真经", Power = 100},
                new Kongfu {ID = 6, Name = "弹指神通", Power = 100}
            };


            //查询所有级别大于8的数据
          /*  var res = new List<MartialArtsMaster>();
            foreach (var temp in masterList)
            {
                if (temp.Level>8)
                {
                    res.Add(temp);
                }
            }*/
            //使用LINQ查询(表达式写法)
            var res = from m in masterList
                //from后面设置查询的集合
                where m.Level > 8 && m.Menpai == "丐帮"
                //where 后面跟查询条件
                //select m;//表示M的结果集合返回
                select m.Name; 
            //扩展方法的写法
            //masterList.Where(Test);
            //扩展方法的lambda表达式写法
            //masterList.Where(m => m.Level > 8 && m.Menpai == "丐帮");



            foreach (var temp in res)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }

        //过滤方法
        static bool Test(MartialArtsMaster master)
        {
            if (master.Level>8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}