using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MyWebApi.Common
{
    /// <summary>
    /// 自定义日志过滤器
    /// </summary>
    public class AuthAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 授权验证的逻辑处理，返回true的则是通过授权，返回了false则不是
        /// </summary>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            return base.IsAuthorized(actionContext);
        }
        /// <summary>
        /// 处理授权失败的事情。
        /// </summary>
        /// <param name="actionContext"></param>
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            base.HandleUnauthorizedRequest(actionContext);
        }
    }
}