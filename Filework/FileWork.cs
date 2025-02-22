using System;
using System.IO;
using System.Text;
using System.Linq;

using static TaskManager.Encrypt;

public class FileWork
{
    public static void DirExist(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }

    public static void EditFile(string name, string content, string path)
    {
        // check is dir exsist
        // if not -> creates dir
        DirExist(path);

        content = EncryptDat(content);

        FileStream file = File.OpenWrite(path + name);
        
        // convert content to byte array to be able to save it into file
        byte[] file_data = new UTF8Encoding(true).GetBytes(content);
        
        // clear file
        file.SetLength(0);

        // add text
        file.Write(file_data);
        file.Close();
    }

    public static string ReadFile(string name, string path)
    {
        DirExist(path);
        if (File.Exists(path + name))
        {
            return DecryptDat(File.ReadAllText(path + name));
        }
        return "Couldn't open the file";
    }

    public static void DeleteFile(string name, string path)
    {
        DirExist(path);
        if (File.Exists(path + name))
        {
            File.Delete(path + name);
        }
    }

    public static string[] GetFilesList(string path)
    {
        DirExist(path);

        string[] files = 
                Directory.GetFiles(path)
                .Select(file => Path.GetFileNameWithoutExtension(file))
                .ToArray();

        return files;
    }
}