﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtouch.Infrastructure.Log;
using Newtouch.Tools;

namespace Newtouch.Infrastructure
{
    /// <summary>
    /// 方法运行监控
    /// </summary>
    public class PerformanceMonitoring
    {
        /// <summary>
        /// 代码运行时间
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="missingHandler"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public static dynamic Running<T>(Func<T> missingHandler, string title, string message, Dictionary<string, string> tags = null)
        {
            var stopwatch = new Stopwatch();
            //  开始监视代码运行时间
            stopwatch.Start();

            //代码主体
            dynamic value = missingHandler.Invoke();

            //  停止监视
            stopwatch.Stop();
            ;
            //记录日志
            LogCore.Info(string.Format("Title:{0};\n message:{1} 方法耗时-{2}", title, message, stopwatch.Elapsed.TotalMilliseconds), message, tags);
            return value;
        }

        /// <summary>
        /// 服务监控
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="action"></param>
        /// <param name="request"></param>
        /// <param name="requestTitle"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public static TResponse RequestMonitor<TRequest, TResponse>(Func<TRequest, TResponse> action, TRequest request, string requestTitle, Dictionary<string, string> tags = null)
        {
            try
            {
                var stopwatch = new Stopwatch();
                LogCore.Info(requestTitle, string.Format("{0}_RequestXML;\n Message:{1}", requestTitle, request), tags);
                stopwatch.Start();
                var response = action.Invoke(request);
                stopwatch.Stop();
                LogCore.Info(requestTitle, string.Format("{0}_ResponseXML;\n Message:{1}", requestTitle, response));
                LogCore.Info(string.Format("Title:{0};方法耗时-{1}", requestTitle, stopwatch.Elapsed.TotalMilliseconds), requestTitle, tags);
                return response;
            }
            catch (Exception ex)
            {
                LogCore.Error(requestTitle, ex, addInfo: tags);
                throw;
            }
        }

        /// <summary>
        /// 服务监控
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <param name="action"></param>
        /// <param name="request"></param>
        /// <param name="requestTitle"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public static void RequestMonitor<TRequest>(Action<TRequest> action, TRequest request, string requestTitle, Dictionary<string, string> tags = null)
        {
            try
            {
                var stopwatch = new Stopwatch();
                var tmpClientNo = Guid.NewGuid().ToString();
                tags = tags ?? new Dictionary<string, string>();
                if (!tags.ContainsKey("tmpClientNo")) tags.Add("tmpClientNo", tmpClientNo);
                LogCore.Info(requestTitle, string.Format("{0}_RequestXML;\n Message:{1}", requestTitle, request.ToJson()), tags);
                stopwatch.Start();
                action.Invoke(request);
                stopwatch.Stop();
                LogCore.Info(string.Format("Title:{0};方法耗时-{1}", requestTitle, stopwatch.Elapsed.TotalMilliseconds), requestTitle, tags);
            }
            catch (Exception ex)
            {
                LogCore.Error(requestTitle, ex, addInfo: tags);
                throw;
            }
        }
    }
}
