using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace student
{
    public class Func
    {
        BaseClass baseclass = new BaseClass();
        // 获取 公告，
        public string get_gg_title()
        {
            string get_gg_sql = "SELECT announcement_title from announcement  ORDER BY announcement_date ASC LIMIT 1";
            return baseclass.Readstr(get_gg_sql, 0);
        }
        public string get_gg_content()
        {
            string get_gg_sql = "SELECT announcement_content from announcement  ORDER BY announcement_date ASC LIMIT 1";
            return  baseclass.Readstr(get_gg_sql, 0);
        }
    }
}