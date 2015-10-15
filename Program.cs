using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNamespace.Logging;

namespace GenericLoggingHelperTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var logger = LogManager.GetLogger(typeof (Program));
                logger.Debug("hi");
                logger.Error("err");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
