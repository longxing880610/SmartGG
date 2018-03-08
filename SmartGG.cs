using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGG
{
    public class SmartParameter
    {
        public static string[] m_subjects = { "王雅平", "雅平", "雅宝贝", "宝贝", "老婆", "女朋友" };
        public static string[] m_predicates = { "是" };
        public static string[] m_objects = { "谁" };
        public static string[] m_specailKey = { "日期", "时间", "节日", "帮助" };

        public static string findKeyWord(string[] list, string input)
        {
            string keyword = null;
            int index = 0;
            foreach (string item in list)
            {
                index = input.IndexOf(item);
                if (index >= 0)
                {
                    keyword = item;
                    break;
                }
            }
            return keyword;
        }
    }
    public class SmartGG
    {
        public SmartGG()
        {
        }

        public StringBuilder ProcUserInput(string input)
        {
            int predicateIndex;
            int keyIndex;
            string tmpStr;
            StringBuilder respBuild = new StringBuilder();

            input = input.Trim();
            tmpStr = SmartParameter.findKeyWord(SmartParameter.m_specailKey, input);

            if (tmpStr != null)
            {
                DateTime now = DateTime.Now;
                switch (tmpStr)
                {
                    case "日期":
                        respBuild.Append("今天是" + now.ToString("yyyy年MM月dd日 HH时mm分ss秒fff毫秒"));
                        break;
                    case "时间":
                        respBuild.Append("今天是" + now.ToString("yyyy年MM月dd日 HH时mm分ss秒fff毫秒"));
                        break;
                    case "节日":
                        if (now.Month == 3 && now.Day == 8)
                        {
                            respBuild.Append("今天是三八女人节,我的女人的节日,祝宝宝节日快乐!!!");
                        }
                        else
                        {
                            respBuild.Append("还在学习中,不知哪个节日.");
                        }
                        break;
                    case "帮助":
                        respBuild.AppendLine("\r\n输入关键词: \"日期\", \"时间\", \"节日\"");
                        respBuild.AppendLine("输入主语:   \"雅平\", \"王雅平\", \"宝贝\", \"雅宝贝\", \"老婆\", \"女朋友\"");
                        respBuild.AppendLine("输入谓语:   \"是\"");
                        respBuild.Append("输入宾语:   \"谁\"");
                        break;
                    default:
                        respBuild.Append("我很笨,还需要多多学习");
                        break;
                }
                goto ProcUserInput_OVER;
            }
            string subjectStr = SmartParameter.findKeyWord(SmartParameter.m_subjects, input);
            string predicateStr = SmartParameter.findKeyWord(SmartParameter.m_predicates, input);
            string objectStr = SmartParameter.findKeyWord(SmartParameter.m_objects, input);

            if (subjectStr != null)
            {
                if (predicateStr != null)
                {
                    if (objectStr != null)
                    {
                        if (subjectStr.Contains("雅"))
                        {
                            respBuild.Append(subjectStr + "是我的亲亲宝贝宇宙无话超级好宝贝,亲亲老婆");
                        }
                        else
                        {
                            respBuild.Append(subjectStr + "是王雅平,亲亲老婆宝贝");
                        }
                        goto ProcUserInput_OVER;
                    }
                }
            }
            respBuild.Append("我很笨,还需要多多学习");
            ProcUserInput_OVER:
            respBuild.AppendLine();
            return respBuild;
        }
    }
}
