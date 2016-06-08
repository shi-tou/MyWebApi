using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApi.Models
{
    /// <summary>
    /// 用户基本信息
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID;
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name;
        /// <summary>
        /// 用户性别
        /// </summary>
        public string Sex;
    }
}