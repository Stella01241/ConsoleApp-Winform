using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryFileAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("測試Log","TryFileAccess");

            try
            {
                throw new Exception("Test exection");
            }
            catch (Exception ex)
            {
                Write(ex.ToString(), "TryFileAccess.Program.Main");
            }

            Console.ReadLine();


        }

        private static void Write(string msg,string modulName)
        {
            //內容
            string content = $" {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {modulName}\r\n{msg}\r\n --------\r\n ";

            //寫入檔案 + 改寫檔案名稱
            string path = $"C:\\Temp1\\{DateTime.Now.ToString("yyyyMMdd")}.log";
            File.AppendAllText(path,content);
        }



        private static void ExecFileAccess()
        {

            //建立檔案
            string path = "C:\\Temp1\\CreateFile.txt";
            File.Create(path);
            //讀取檔案
            string fileContent = File.ReadAllText("C:\\Temp1\\ForRead.txt");
            Console.WriteLine(fileContent);
            //覆寫檔案

            Encoding myEncode =
            //  Encoding.ASCII;
               
            Encoding.GetEncoding(10001);


            string contentForWrite = "第一行\r\n第二行";

            File.WriteAllText("C:\\Temp1\\ForWrite.txt", contentForWrite, myEncode);

            //附加
            File.WriteAllText("C:\\Temp1\\ForWrite.txt",contentForWrite);
            //如果檔案存在就刪除
            if (File.Exists("C:\\Temp1\\ForDelete.txt"))
            {
                File.Delete("C:\\Temp1\\ForDelete.txt");
            }
   

        }


        private static void ExeFolderAccess()
        {
            string path = "C:\\Temp1\\SubFolder\\";
            string mainPath = "C:\\Temp1\\";

            //讀取資料
            string[] files = Directory.GetFiles(mainPath, "*.txt");
            ListName(files);

            Console.WriteLine("-----");
            var filesOfFullFolser = Directory.EnumerateFileSystemEntries(mainPath, "*.txt", SearchOption.AllDirectories);
            ListName(filesOfFullFolser);
            Console.ReadLine();
        }




        private static void ListName(IEnumerable<string> files)
        {
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }

        }



    }
}
