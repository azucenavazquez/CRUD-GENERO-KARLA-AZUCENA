using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilerias
{
    public class clsULogExceptions
    {
        public static string PathToLogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyApp", @"log.txt");

        public static void WriteException(string error)
        {
            string texto = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + @"\t" + error;
            File.AppendAllLines(clsULogExceptions.PathToLogFile, new String[] { texto });
        }
    }
}
