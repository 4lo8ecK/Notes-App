using System;
using System.IO;
using System.Text;
using System.Linq;

using static TaskManager.Encrypt;

public class FileWork
{
    public static bool DirExist(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            return true;
        }
        else if (Directory.Exists(path))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool EditFile(string name, string content, string path)
    {
        // check is dir exsist
        // if not -> creates dir
        if (DirExist(path)&&File.Exists(path+"/"+name))
        {
            content = EncryptDat(content);

            FileStream file = File.OpenWrite(path + "/" + name);

            // convert content to byte array to be able to save it into file
            byte[] file_data = new UTF8Encoding(true).GetBytes(content);

            // clear file
            //file.SetLength(0);

            // add text
            file.Write(file_data);
            file.Close();
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string ReadFile(string name, string path)
    {
        DirExist(path);
        if (File.Exists(path +"/"+ name))
        {
            return DecryptDat(File.ReadAllText(path + name));
        }
        return "Couldn't open the file";
    }
    public static string ReadFile(string name)
    {
        if (File.Exists(name))
        {
            return DecryptDat(File.ReadAllText(name));
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

    public static string[] GetFilesList(string path, string extencion)
    {
        DirExist(path);

        string[] files = 
                Directory.GetFiles(path, "*"+extencion)
                .Select(file => Path.GetFileNameWithoutExtension(file))
                .ToArray();

        string[] result = new string[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            result[i] = files[files.Length - i - 1];
        }

        return result;
    }
}