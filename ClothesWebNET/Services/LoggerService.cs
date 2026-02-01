using System;
using System.IO;
using System.Web;

namespace ClothesWebNET.Services
{
    public static class LoggerService
    {
        public static void Log(string message)
        {
            try
            {
                string path = HttpContext.Current.Server.MapPath("~/App_Data/log.txt");
                string content = $"{DateTime.Now}: {message}{Environment.NewLine}";
                File.AppendAllText(path, content);
            }
            catch
            {
                // Silently fail logging to avoid crashing app
            }
        }
    }
}
