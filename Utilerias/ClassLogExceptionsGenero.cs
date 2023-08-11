using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilerias
{

    public static string PathToLogFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CRUD-GENERO", @"log.txt");

    public static void WriteException(string error)
    {
        string texto = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + @"\t" + error;
        File.AppendAllLines(ClassLogExceptionsGenero.PathToLogFile, new String[] { texto });
    }
}
}
