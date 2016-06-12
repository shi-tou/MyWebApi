using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace MyWebApi.Common
{
    /// <summary>
    /// 自定义异常过滤器
    /// </summary>
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Utils.SaveLog("Exception", actionExecutedContext.Exception.ToString());
        }
    }
}