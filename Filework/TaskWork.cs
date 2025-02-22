using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TaskSaver.Filework
{
    public class TaskWork : FileWork
    {
        public const string EXT = ".tsk";

#if DEBUG
        public  string path = @"D:/tasks/";
#else
        public  string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
#endif
        public void EditTask(string name, string content)
        {
            string name_ext = name + EXT;
            EditFile(name_ext, content, path);
        }

        public string ReadTask(string name)
        {
            string name_ext = name + EXT;
            return ReadFile(name_ext, path);
        }

        public void DeleteTask(string name)
        {
            string name_ext = name + EXT;

            DeleteFile(name_ext, path);
        }

        public string[] GetTasksList()
        {
            return GetFilesList(path);
        }
    }
}
