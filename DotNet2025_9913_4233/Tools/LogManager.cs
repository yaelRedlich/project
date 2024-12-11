using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string path = "Log";
        public static string getCurrentFolderPath()
        {
            return DateTime.Now.Month.ToString();
        }
        public static string getCurrentFilePath()
        {
            return DateTime.Now.Day.ToString() + @"\" + DateTime.Now.Month.ToString() + @"\" + DateTime.Now.Year.ToString();
        }
        public static void writeToLog(string projectName, string func, string messege)
        {
            string rootDay = path + @"\" + DateTime.Now.Year + @"\" + DateTime.Now.Month + @"\" + DateTime.Now.Day;
            string rootMounth = path + @"\" + DateTime.Now.Year + @"\" + DateTime.Now.Month;

            if (!Directory.Exists(rootMounth))
            {
                Directory.CreateDirectory(rootMounth);
                FileStream fs =  File.Create(rootDay + @".txt");
                fs.Close();
            }
            else if (!File.Exists(rootDay + @".txt"))
            {
                FileStream fs = File.Create(rootDay + @".txt");
                fs.Close(); 
            }

            string contentFile = $"{DateTime.Now}\t{projectName}.{func}:\t{messege}";
            File.AppendAllText(rootDay + @".txt", contentFile + Environment.NewLine);


        }
        public static void cleanLog()
        {
            var directories = Directory.GetDirectories(path);

            foreach (var d in directories)
            {
                var yearDirectories = Directory.GetDirectories(d);
                foreach (var dir in yearDirectories)
                {
                    if (Directory.GetCreationTime(dir).Month != DateTime.Now.Month && (Directory.GetCreationTime(dir).Month != DateTime.Now.Month - 1))
                        Directory.Delete(dir, true);
                }
            }
        }

    }
}
