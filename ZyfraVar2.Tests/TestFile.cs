using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZyfraVar2.Tests
{
    public class TestFile
    {
        public static void CreateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Логин;Пароль");

                    for (int i = 0; i <= 2; i++)
                    {
                        writer.WriteLine($"user{i};password{i}");
                    }
                }
            }

        }
    }
}
