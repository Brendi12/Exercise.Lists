using System;
using System.Collections.Generic;
using System.IO;
using Exercise.List.Models;

namespace Exercise.List.Utils
{
    public static class OriginalTextFileProcessor
    {
        // load() PEOPLE objets from  FILE   
        // --> extract lines from file  
        // ->  create a List of objects from each column 
        // -> each object must have PROPERTIES VALUES  taht match with each FILE COLUMN

        // Save() people FILE from objects  


        public static void ComposeFile(List<People> p)
        {
            string path = @"C:\temp\people.csv";
            FileInfo info = new FileInfo(path);
            if (!info.Exists)
            {
                info.Create();

            }
            List<string> Lines = new List<string>();
            Lines.Add("Name, Id, IsActive");

            for (int i = 0; i < p.Count; i++)
            {
                Lines.Add($"{p[i].Name},{p[i].Id},{p[i].IsActive}");
            }

            System.IO.File.AppendAllLines(path, Lines);


            // System.IO.File.AppendAllLines(path, Lines);


            ///Write from file to List

            var line = System.IO.File.ReadAllLines(path);
            //Console.WriteLine(line.GetType());

            List<People> people = new List<People>();
            string spearator = ", ";

            String[] strlist = new String[line.Length];

            for (int i = 1; i <= 3; i++)
            {
                strlist = line[i].Split(",");
                people.Add(new People { Name = strlist[0], Id = Int32.Parse(strlist[1]), IsActive = bool.Parse(strlist[2]) });
            }

            foreach (People people1 in people)
            {
                Console.Write(people1.Name + " ");
                Console.Write(people1.Id + " ");
                Console.WriteLine(people1.IsActive + " ");

            }

        }
    }
}