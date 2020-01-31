using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericHandler
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string path = context.Server.MapPath("c#.jpg");
            context.Response.ContentType = "image/jpg";
            context.Response.WriteFile(path);
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