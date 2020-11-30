using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace EasyClientFTP
{
    public class FTPHandel
    {
        public static void HandelFTP(string user, string pass, string file)
        {
            string localdest = @"C:\Users\Jahangir Abdullayev\Documents\ServerBackups\" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".xml";

            // file as string
            String result = String.Empty;

            // connect to file and download it
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(file);
            request.Credentials = new NetworkCredential(user, pass);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // get response
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            // open streams
            Stream ftpstream = response.GetResponseStream();
            FileStream fs = new FileStream(localdest, FileMode.Create);

            // writes file
            byte[] buffer = new byte[1024];
            int byteRead = 0;
            while (byteRead != 0)
            {
                byteRead = ftpstream.Read(buffer, 0, 1024);
                fs.Write(buffer, 0, byteRead);
            }

            // close off streams
            ftpstream.Close();
            fs.Close();
        }
    }
}
