using System;
using System.Collections.Generic;
using System.IO;
using DAL;  // LogOperation sınıfını kullanmak için DAL namespace'ini dahil ediyoruz

namespace BLL
{
    public class LogManager
    {
        private static readonly object lockObj = new object();
        public static readonly string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "log.txt");

        public void LogAction(string message, string entity)
        {
            SaveLogToDatabase(message);  
            LogActionToFile(message, entity); 
        }

        private void SaveLogToDatabase(string message)
        {
            var logOperation = new DAL.LogOperation();  
            logOperation.SaveLog(message);  
        }

        private void LogActionToFile(string message, string entity)
        {
            try
            {
                string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {entity} - {message}";

                lock (lockObj)
                {
                    File.AppendAllText(logFilePath, logMessage + Environment.NewLine);  // Log dosyasına yazdırır
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log dosyasına yazma hatası: " + ex.Message);
            }
        }

        public List<Logs> GetAllLogs()
        {
            var logOperation = new DAL.LogOperation();
           return logOperation.GetLogs();
        }
    }
}


