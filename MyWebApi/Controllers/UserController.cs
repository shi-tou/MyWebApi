using MyWebApi.Common;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWebApi.Controllers
{
    /// <summary>
    /// 用户信息管理
    /// </summary>
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        public List<UserModel> UserList = new List<UserModel>(){
            new UserModel{ UserID=1,Name="张三",Sex="男"},
            new UserModel{ UserID=1,Name="李四",Sex="男"},
            new UserModel{ UserID=1,Name="王五",Sex="男"},
            new UserModel{ UserID=1,Name="赵六",Sex="男"}
        };
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        [Route("List")]
        [LogAttribute(Message = "获取用户列表")]
        [HttpGet]
        public List<UserModel> List()
        {
            return UserList;
        }

        /// <summary>
        /// 获取指定ID的用户信息
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns></returns>
        [Route("Detail")]
        [LogAttribute(Message = "获取指定ID的用户信息")]
        [HttpGet]
        public UserModel Detail(int id)
        {
            return UserList.Where(u => u.UserID == id).FirstOrDefault();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="model">用户信息</param>
        /// <returns></returns>
        [Route("Add")]
        [LogAttribute(Message = "添加用户")]
        [HttpPost]
        public List<UserModel> Add(UserModel model)
        {
            UserList.Add(model);
            return UserList;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户ID</param>
        [Route("Delete")]
        [LogAttribute(Message = "删除用户")]
        [HttpPost]
        public List<UserModel> Delete(int id)
        {
            return UserList.Where(u => u.UserID != id).ToList();
        }

    }
}