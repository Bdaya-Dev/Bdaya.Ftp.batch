using System;
using System.IO;
using System.Linq;
using System.Net;

namespace Bdaya.Ftp.batch
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter The User: ");
            var ftpuser = Console.ReadLine();
            Console.WriteLine("Enter The ServerUrl: ");
            var ftpServerUrl = Console.ReadLine();

            Console.WriteLine("Enter The password: ");
            var ftppass = Console.ReadLine();

            Console.WriteLine("Enter The DirPath: ");
            var dirPath = Console.ReadLine();

            BdayaFtpClient ftp = new BdayaFtpClient(ftpuser, ftppass, ftpServerUrl, dirPath);
            ftp.UploadDirectory();
            Console.WriteLine("DONE");
            Console.ReadLine();

        }





    }
}