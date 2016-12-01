﻿using SyntacticSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Pub
{
    public class PubMethod
    {
        public static void WirteExp(Exception ex)
        {
            var logPath = FileSugar.MergeUrl(
                FileSugar.GetMapPath("~/"),
                "log",
                DateTime.Now.ToString("yyyy-MM-dd.txt")
                );
            FileSugar.AppendText(logPath, "***********{0}{1}***********".ToFormat("开始:", DateTime.Now));
            FileSugar.AppendText(logPath, ex.Message);
            FileSugar.AppendText(logPath, "***********{0}***********\r\n".ToFormat("结束"));
        }

    }
}