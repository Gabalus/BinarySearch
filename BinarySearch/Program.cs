using System;
using System.Collections.Generic;
using System.IO;

namespace BinarySearch
{
    class Program
    {
        const string fileName = "AppSettings.dat";

        static void Main()
        {
            dynamic a = 2;
            object b = 2;
            Temp temp = new Temp();
            Temp2 temp2 = new Temp2();
            object x = 21;
            object y = x ?? 5;
            if (x == null)
            {
                y = 5;
            }
            else
            {
                y = x;
            }
            TempMethod(temp);
            TempMethod(temp2);

            Console.WriteLine(y + " "+ x);
            //WriteDefaultValues();
            //DisplayValues();
        }

        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                Single s = 1.31235F;
                writer.Write(s);
                writer.Write(@"Temp");
                writer.Write(@"a");
                writer.Write(0);
                writer.Write(true);
            }
        }

        public static void DisplayValues()
        {
            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                    autoSaveTime = reader.ReadInt32();
                    showStatusBar = reader.ReadBoolean();
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }

        public static Temp TempMethod(Interface3 Temp)
        {
            return new Temp();
        }

        public static Temp TempMethod2(IEnumerator<Interface1> Temp)
        {
            return new Temp();
        }
    }
}
