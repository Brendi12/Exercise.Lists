using Exercise.List.Models;
using Exercise.List.Utils;
using Exercise.Lists.Models;
using Exercise.Lists.Utils;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise.List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OriginalTextFileProcessor.ComposeFile(Save());
            string path = @"C:\temp\people.csv";
            string pathLog = @"C:\temp\logs.csv";
            People p = new People();

            GenericClasess.SaveToTextFile(SavePeople(), path);
            GenericClasess.LoadFromTextFile<People>(path);

            GenericClasess.SaveToTextFile(SaveLogs(), pathLog);
            GenericClasess.LoadFromTextFile<Logs>(pathLog);


        }
        public static List<People> SavePeople()
        {
            List<People> p = new List<People>();
            p.Add(new People { Id = 01, Name = "Brendi", IsActive = true });
            p.Add(new People { Id = 02, Name = "Marsi", IsActive = true });
            p.Add(new People { Id = 03, Name = "Sindi", IsActive = false });
            return p;
        }
        public static List<Logs> SaveLogs()
        {
            List<Logs> l = new List<Logs>();
            l.Add(new Logs { ErrorCode = 123, Message = "Error nO.1", timeOfEvent = DateTime.Now });
            l.Add(new Logs { ErrorCode = 404, Message = "Error found", timeOfEvent = DateTime.Now });
            return l;
        }
    }
}
