using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LinqToXML从创建到读取.res
{
    static class DeleteXML
    {
        public static string DeleteXMLFile(string path)
        {
            bool statusCode = true;
            string errorMsg = null;
            try
            {
                //删除给定目录下的所有文件和文件夹
                //DirectoryInfo dir = new DirectoryInfo(path);
                //FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                //foreach (FileSystemInfo i in fileinfo)
                //{
                //    if (i is DirectoryInfo)            //判断是否文件夹
                //    {
                //        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                //        subdir.Delete(true);          //删除子目录和文件
                //    }
                //    else
                //    {
                //        //如果 使用了 streamreader 在删除前 必须先关闭流 ，否则无法删除 sr.close();
                //        File.Delete(i.FullName);      //删除指定文件
                //    }
                //}
                if(File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch(Exception errorinfo)
            {
                statusCode = false;
                errorMsg = errorinfo.ToString();
            }
            return statusCode ? "删除成功!" : ($"删除失败，失败信息：{errorMsg}");
        }
    }
}
