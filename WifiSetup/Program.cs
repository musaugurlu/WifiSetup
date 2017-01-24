using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WifiSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:/QUSecure";
            if (Directory.Exists(path))
            {
                Console.WriteLine("The path C:/QUSecure Exists Already");
                return;
            }

            Directory.CreateDirectory(path);

            // Write out the xml to a temporary file
            System.IO.File.WriteAllText(@"C:\QUSecure\WLANExport.xml", WifiResource.WifiConf);


            // Run netsh with the temp file as input 
            System.Diagnostics.Process.Start("CMD.exe", "/C netsh wlan add profile filename=\"C:\\QUSecure\\WLANExport.xml\" & ping 127.0.0.1 -n 3 > nul & netsh wlan connect name=\"RCSA-Static\"");

            // Remove the temp file
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
            System.IO.File.Delete(@"C:\QUSecure\WLANExport.xml");

            // Remove the temp folder

            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(2).TotalMilliseconds);
            System.IO.Directory.Delete(@"C:\QUSecure");
        }
    }
}
