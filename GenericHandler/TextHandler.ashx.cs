﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericHandler
{
    /// <summary>
    /// Summary description for TextHandler
    /// </summary>
    public class TextHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}