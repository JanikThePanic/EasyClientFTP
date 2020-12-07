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
            // connect to file and use the download method
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

        public static void FTPUploadFile(string user, string pass, string file, string localDest)
        {
            // connect to file and use the upload method
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(file);
            request.Credentials = new NetworkCredential(user, pass);
            request.Method = WebRequestMethods.Ftp.UploadFile;


            // get response
            Stream response = request.GetRequestStream();
            FileStream fs = File.OpenRead(localDest);

            // writes file
            byte[] buffer = new byte[1024];
            int byteRead = 0;
            do
            {
                byteRead = fs.Read(buffer, 0, buffer.Length);
                response.Write(buffer, 0, byteRead);

            }
            while (byteRead > 0);

            // close streams
            response.Close();
            fs.Close();
        }
    }
}
