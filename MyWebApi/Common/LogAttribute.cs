using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MyWebApi.Common
{
    /// <summary>
    /// 自定义日志过滤器
    /// </summary>
    public class LogAttribute : ActionFilterAttribute
    {
        public string Message { get; set; }

        /// <summary>
        /// 执行Action之前
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ActionArguments != null && actionContext.ActionArguments.Any())
            {
                Utils.SaveLog(actionContext.Request.RequestUri.ToString(), JsonConvert.SerializeObject(actionContext.ActionArguments));
            }
        }
        /// <summary>
        /// 执行Action之后
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //Utils.SaveLog(actionExecutedContext.Request.RequestUri.ToString(), JsonConvert.SerializeObject(actionExecutedContext.Response.Content.ToString()));
        }

    }
}