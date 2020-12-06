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
        public static bool FTPDownloadFile(string user, string pass, string file, string localDest)
        {
            // file as string
            String result = String.Empty;

            // connect to file and download it
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(file);
            request.Credentials = new NetworkCredential(user, pass);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // get response
            try
            {
                // get response
                FtpWebResponse testResponse = (FtpWebResponse)request.GetResponse();
            }
            catch
            {
                // if theres an error getting a response (usally means a bad password or username)
                return false;
            }

            // get response
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            // open streams
            Stream ftpstream = response.GetResponseStream();
            FileStream fileStream = new FileStream(localDest, FileMode.Create);

            // writes file
            byte[] buffer = new byte[1024];
            int byteRead = 0;
            do
            {
                byteRead = ftpstream.Read(buffer, 0, buffer.Length);
                fileStream.Write(buffer, 0, byteRead);

            }
            while (byteRead > 0);

            // close off streams
            ftpstream.Close();
            fileStream.Close();

            return true;
        }
    }
}
