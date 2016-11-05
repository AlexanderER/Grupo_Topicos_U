using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace Ejemplo_EnterpriseLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            LogEntry entry = new LogEntry();
            entry.Message  = "Mensaje a registrar";
            entry.Severity = System.Diagnostics.TraceEventType.Critical;
            entry.Categories.Add("General");
            Logger.Write(entry);
        }
    }
}
