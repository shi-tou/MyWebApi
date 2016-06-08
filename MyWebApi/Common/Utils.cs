﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace MyWebApi.Common
{
    public class Utils
    {
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="strTitle"></param>
        /// <param name="strContent"></param>
        public static void SaveLog(string strTitle, string strContent)
        {
            try
            {
                string Path = AppDomain.CurrentDomain.BaseDirectory + "Log/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/";
                string FilePath = Path + DateTime.Now.Day + "_Log.txt";
                if (!Directory.Exists(Path)) Directory.CreateDirectory(Path);
                if (!File.Exists(FilePath))
                {
                    FileStream FsCreate = new FileStream(FilePath, FileMode.Create);
                    FsCreate.Close();
                    FsCreate.Dispose();
                }
                FileStream FsWrite = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
                StreamWriter SwWrite = new StreamWriter(FsWrite);
                SwWrite.WriteLine(string.Format("{0}{1}[{2}]{3}", "--------------------------------", strTitle, DateTime.Now.ToString("HH:mm"), "--------------------------------"));
                SwWrite.Write(strContent);
                SwWrite.WriteLine("\r\n");
                SwWrite.WriteLine(" ");
                SwWrite.Flush();
                SwWrite.Close();
            }
            catch { }
        }
        /// <summary>
        /// 获取配置文件的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            try { return ConfigurationManager.AppSettings[key].ToString(); }
            catch { return ""; }
        }
    }
}