﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace NetworkSocket
{
    /// <summary>
    /// 定义监听服务的行为
    /// </summary>
    public interface IListener : IDisposable
    {
        /// <summary>
        /// 使用中间件
        /// </summary>
        /// <param name="middleware">中间件</param>
        void Use(IMiddleware middleware);

        /// <summary>
        /// 开始启动监听        
        /// </summary>
        /// <param name="localEndPoint">本机ip和端口</param>
        /// <param name="backlog">挂起连接队列的最大长度</param>
        void Start(IPEndPoint localEndPoint, int backlog);
    }
}
