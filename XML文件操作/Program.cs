using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML文件操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建技能信息集合，用来存储所有的技能信息
            List<Skill> skillList = new List<Skill>();
            //专门用来解析xml文档的
            XmlDocument xmlDoc = new XmlDocument();
            //选择要加载解析的xml文档
            xmlDoc.Load("skillinfo.txt");
            //xmlDoc.LoadXml();//传递一个字符串（xml格式的字符串）

            //得到根节点
            XmlNode rootNode = xmlDoc.FirstChild;//获取第一个节点

            //得到根节点下面的子节点的集合
            XmlNodeList skillNodeList = rootNode.ChildNodes;//获取当前节点下的所有子节点

            foreach (XmlNode skillNode in skillNodeList)
            {
                Skill skill = new Skill();

                XmlNodeList fieldNodeList = skillNode.ChildNodes;//获取skill节点下面所有的节点

                foreach (XmlNode fieldNode in fieldNodeList)
                {
                    if (fieldNode.Name == "id")
                    {
                        int id = Int32.Parse(fieldNode.InnerText);//获取节点内部的文本
                        skill.Id = id;
                    }else if (fieldNode.Name == "name")
                    {
                        string name = fieldNode.InnerText;
                        skill.Name = name;
                        skill.Lang = fieldNode.Attributes[0].Value;
                    }
                    else
                    {
                        skill.Damage = Int32.Parse(fieldNode.InnerText);
                    }
                }
                skillList.Add(skill);
            }
            foreach (Skill skill in skillList)
            {
                Console.WriteLine(skill);
            }
            Console.ReadKey();
        }
    }
}
