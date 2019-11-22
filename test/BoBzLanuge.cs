using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace test
{
    public class BoBzLanuge
    {
        /// <summary>
        /// 获取字符串编码
        /// </summary>
        /// <param name="info">要检测的字符串</param>
        /// <returns>所属的语言</returns>
       public static string getCodeName(string info)
        {
            List<encodeEntity> list = getCodeList();
            List<recordEntity> getList = new List<recordEntity>();
            Regex regex = null;
            int c = 0;
            foreach (var item in list)
            {
                regex = new Regex(item.reg.ToString());
                if (regex.IsMatch(info))
                {
                    getList.Add(new recordEntity() { count = info.Length - (regex.Replace(info, "").Length), Zname = item.Zname });
                }
            }
            if (getList.Count > 0)
            {
                if (getList.Count == 1)
                {
                    return getList[0].Zname;
                }
                else
                {
                    string name = "";
                    int k = 0;
                    foreach (var item in getList)
                    {
                        if (item.count > k)
                        {
                            k = item.count;
                        }
                    }
                    foreach (var item in getList)
                    {
                        if (item.count == k)
                            name += item.Zname + "\t";
                    }
                    return name;
                }
            }
            else
            {
                return "没有找到所属的编码";
            }
        }
        /// <summary>
        /// 获取搜有 unicode 编码
        /// 本人只找到这么多，如果没有您需要的可以自行添加
        /// </summary>
       public static List<encodeEntity> getCodeList()
        {
            List<encodeEntity> list = new List<encodeEntity>(){
                new encodeEntity(){reg="[\u0041-\u005A\u0061-\u007A]",Zname="英文"},
                //new dictionaryClass(){reg="[\u2E80-\u2FDF\u3100-\u312F\u3400-\u4DBF\u4E00-\u9FFF\uF900-\uFAFF]",Zname="中文"},
                new encodeEntity(){reg="[\u4e00-\u9fa5]",Zname="中文"},                
                //new dictionaryClass(){reg="[\u3040-\u30FF\u31F0-\u31FF]",Zname="日文"},
                new encodeEntity(){reg="[\u0800-\u4e00]",Zname="日文"},
                new encodeEntity(){reg="[\u1100-\u11FF\u3130-\u318F\uAC00-\uD7AF]",Zname="韩文"},
                new encodeEntity(){reg="[\u0E00-\u0E7F]",Zname="泰文"},
                new encodeEntity(){reg="[\u0E80-\u0EFF]",Zname="寮文"},
                new encodeEntity(){reg="[\u0F00-\u0FFF]",Zname="藏文"},
                new encodeEntity(){reg="[\uA000-\uA4CF]",Zname="彝文"},
                new encodeEntity(){reg="[\u1800-\u18AF]",Zname="蒙古文"},
                new encodeEntity(){reg="[\u1000-\u109F]",Zname="缅甸文"},
                new encodeEntity(){reg="[\u1780-\u17FF]",Zname="高棉文"},
                new encodeEntity(){reg="[\u00C0-\u02AF\u1E00-\u1EFF]",Zname="拉丁文Latin"},
                new encodeEntity(){reg="[\u0370-\u03FF\u1F00-\u1FFF\u2C80-\u2CFF]",Zname="希腊文Greek"},
                new encodeEntity(){reg="[\u0590-\u05FF]",Zname="希伯来文 Hebrew"},
                new encodeEntity(){reg="[\u0600-\u06FF\u0750-\u077F]",Zname="阿拉伯文Arabic"},
                new encodeEntity(){reg="[\u0700-\u074F]",Zname="叙利亚文Syriac"},
                new encodeEntity(){reg="[\u0400-\u052F]",Zname="西里尔文Cyrillic"},
                new encodeEntity(){reg="[\u0530-\u058F]",Zname="亚美尼亚文Armenian"},
                new encodeEntity(){reg="[\u0980-\u09FF]",Zname="孟加拉文Bengali"},
                new encodeEntity(){reg="[\u0D80-\u0DFF]",Zname="僧伽罗文Sinhala斯里兰卡文"},
                new encodeEntity(){reg="[\u10A0-\u10FF\u2D00-\u2D2F]",Zname="乔治亚文Georgian英国古文"},
                new encodeEntity(){reg="[\u1680-\u169F]",Zname="欧甘文Ogham爱尔兰文"},
                new encodeEntity(){reg="[\u16A0-\u16FF]",Zname="如尼文Runic北欧古文"},
                new encodeEntity(){reg="[\u0780-\u07BF]",Zname="塔纳文Thaana一种印度文"},
                new encodeEntity(){reg="[\uA800-\uA82F]",Zname="比哈文Syloti Nagri一种印度文"},
                new encodeEntity(){reg="[\u1900-\u194F]",Zname="林布文Limbu一种印度文"},
                new encodeEntity(){reg="[\u1A00-\u1A1F]",Zname="布吉文Buginese一种印度文"},
                new encodeEntity(){reg="[\u0B00-\u0B7F]",Zname="奥里雅文Oriya一种印度文"},
                new encodeEntity(){reg="[\u0B80-\u0BFF]",Zname="泰米尔文Tamil一种印度文"},
                new encodeEntity(){reg="[\u0C00-\u0C7F]",Zname="泰卢固文Telugu一种印度文"},
                new encodeEntity(){reg="[\u0C80-\u0CFF]",Zname="卡纳达文Kannada一种印度文"},
                new encodeEntity(){reg="[\u0900-\u097F]",Zname="天城体梵文Devanagari一种印度文"},
                new encodeEntity(){reg="[\u0A00-\u0A7F]",Zname="古尔穆基文Gurmukhi一种印度文"},
                new encodeEntity(){reg="[\u0A80-\u0AFF]",Zname="古吉拉特文Gujarati一种印度文"},
                new encodeEntity(){reg="[\u0D00-\u0D7F]",Zname="马拉雅拉姆文Malayalam一种印度文"},
                new encodeEntity(){reg="[\u1700-\u171F]",Zname="他加禄文Tagalog一种菲律宾文"},
                new encodeEntity(){reg="[\u1720-\u173F]",Zname="汉奴劳文Hanunoo一种菲律宾文"},
                new encodeEntity(){reg="[\u1740-\u175F]",Zname="Buhid一种菲律宾文"},
                new encodeEntity(){reg="[\u1760-\u177F]",Zname="Tagbanwa一种菲律宾文"},
                new encodeEntity(){reg="[\u13A0-\u13FF]",Zname="彻罗基文Cherokee美国印弟安文"},
                new encodeEntity(){reg="[\u1950-\u197F]",Zname="Tai Le中缅边境民族文"},
                new encodeEntity(){reg="[\u1980-\u19DF]",Zname="新傣文中国少数民族文"},
                new encodeEntity(){reg="[\u2C00-\u2C5F]",Zname="格拉哥里文Glagolitic一种斯拉夫文"},
                new encodeEntity(){reg="[\u1200-\u139F\u2D80-\u2DDF]",Zname="衣索比亚文Ethiopic"},
                new encodeEntity(){reg="[\u2D30-\u2D7F]",Zname="提非纳文Tifinagh一种衣索匹亚文"}

            };
            return list;

        }
    }
    /// <summary>
    /// 语言实体
    /// </summary>
    public class encodeEntity
    {
        public string reg { get; set; }
        public string Zname { get; set; }
    }
    /// <summary>
    /// 记录实体
    /// </summary>
    public class recordEntity
    {
        public int count { get; set; }
        public string Zname { get; set; }
    }
}
