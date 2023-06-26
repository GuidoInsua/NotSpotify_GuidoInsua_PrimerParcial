using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotSpotify.Utilidades
{
    public class Logs
    {
        public static void Log(string message)
        {
            string logFilePath = "..\\..\\..\\..\\Logs\\log.txt";
            string logMessage = $"{DateTime.Now}: {message}";

            try
            {
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de registro: {ex.Message}");
            }
        }
    }
}
