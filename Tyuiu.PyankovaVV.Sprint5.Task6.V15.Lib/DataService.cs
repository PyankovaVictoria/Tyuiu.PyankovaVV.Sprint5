﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PyankovaVV.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= 'А') && (line[i] <= 'я'))
                        {
                            if ((line[i + 1] == ' ') || (line[i + 1] == '.') || (line[i + 1] == ','))
                            {
                                count++;
                            }
                        }
                    }
                }

            }
            return count;
        }
    }
}
