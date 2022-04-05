using System.Diagnostics;

namespace SharpIceLog
{
    public interface Logger
    {
        public static string Time = DateTime.Now.ToString("hh:mm:ss");
        public static void LogInfo(string Logs)
        {
            string CallerName = new StackTrace().GetFrame(1).GetMethod().ReflectedType.FullName + "." + new StackTrace().GetFrame(1).GetMethod().Name.ToString(); // 获取调用者命名空间，类名和方法名
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[" + Time + "]" + " " + "[" + CallerName + "/INFO" + "]" + ": " + Logs);
        }
        public static void LogWarning(string Logs)
        {
            string CallerName = new StackTrace().GetFrame(1).GetMethod().ReflectedType.FullName + "." + new StackTrace().GetFrame(1).GetMethod().Name.ToString(); // 获取调用者命名空间，类名和方法名
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + Time + "]" + " " + "[" + CallerName + "/Warning" + "]" + ": " + Logs);
        }
        public static void LogError(string Logs)
        {
            string CallerName = new StackTrace().GetFrame(1).GetMethod().ReflectedType.FullName + "." + new StackTrace().GetFrame(1).GetMethod().Name.ToString(); // 获取调用者命名空间，类名和方法名
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[" + Time + "]" + " " + "[" + CallerName + "/Error" + "]" + ": " + Logs);
        }
        public static void LogFatal(string Logs)
        {
            string CallerName = new StackTrace().GetFrame(1).GetMethod().ReflectedType.FullName + "." + new StackTrace().GetFrame(1).GetMethod().Name.ToString(); // 获取调用者命名空间，类名和方法名
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[" + Time + "]" + " " + "[" + CallerName + "/Fatal" + "]" + ": " + Logs);
        }
        public static void LogDebug(string Logs)
        {
            string CallerName = new StackTrace().GetFrame(1).GetMethod().ReflectedType.FullName + "." + new StackTrace().GetFrame(1).GetMethod().Name.ToString(); // 获取调用者命名空间，类名和方法名
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[" + Time + "]" + " " + "[" + CallerName + "/Debug" + "]" + ": " + Logs);
        }
    }
}