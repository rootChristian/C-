using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Logger
    {
        private String currentDirectory
        {
            get;
            set;
        }

        private String fileName
        {
            get;
            set;
        }

        private String filePath
        {
            get;
            set;
        }
        
        // Type logger
        public enum LogType { info, warning, alert };

        // Method log to file
        public void LogToFile(string sms, LogType logType)
        {
            // Create the folder logger
            string folderName = @"C:\Users\kemgang\Desktop\Basis_C#\CLASSI\Third\Third";
            string pathString = System.IO.Path.Combine(folderName, "Logger");
            System.IO.Directory.CreateDirectory(pathString);
            
            string file;
            this.currentDirectory = Directory.GetCurrentDirectory();
            switch (logType)
            {
                
                case LogType.info:
                    file = string.Format("LogInfo_{0:yyyy-MM-dd_hh-mm-ss}.txt", DateTime.Now);
                    this.fileName = file;
                    this.filePath = this.currentDirectory + "../../../Logger/" + this.fileName;
                    using (System.IO.StreamWriter w = System.IO.File.AppendText(this.filePath))
                    {
                        w.Write("\r\nLog Entry : ");
                        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                        w.WriteLine(" {0}", sms);
                        w.WriteLine("-----------------------------------------------");
                    }
                    break;
                case LogType.warning:
                    file = string.Format("LogWarning_{0:yyyy-MM-dd_hh-mm-ss}.txt", DateTime.Now);
                    this.fileName = file;
                    this.filePath = this.currentDirectory + "../../../Logger/" + this.fileName;
                    using (System.IO.StreamWriter w = System.IO.File.AppendText(this.filePath))
                    {
                        w.Write("\r\nLog Entry : ");
                        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                        w.WriteLine(" {0}", sms);
                        w.WriteLine("-----------------------------------------------");
                    }
                    break;
                case LogType.alert:
                    file = string.Format("LogAlert_{0:yyyy-MM-dd_hh-mm-ss}.txt", DateTime.Now);
                    this.fileName = file;
                    this.filePath = this.currentDirectory + "../../../Logger/" + this.fileName;
                    using (System.IO.StreamWriter w = System.IO.File.AppendText(this.filePath))
                    {
                        w.Write("\r\nLog Entry : ");
                        w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                        w.WriteLine(" {0}", sms);
                        w.WriteLine("-----------------------------------------------");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
