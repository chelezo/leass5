using System;
using System.IO;

namespace binary
{
    using System.Runtime.Serialization.Formatters.Binary;
    class Program
    {
        static void Main(string[] args)
        {
            ClassBinary class1 = new ClassBinary();
            class1.TxtHello();
            class1.EnterNumer = Convert.ToInt32(Console.ReadLine());
            BinaryFormatter formater = new BinaryFormatter();
            int str = class1.EnterNumer;
            /*FileStream stream = new FileStream(@"NumBin.dat", FileMode.OpenOrCreate);
            formater.Serialize(stream, str);
            stream.Close();
            ClassBinary bu = (ClassBinary)formater.Deserialize(new FileStream("NumBin.dat", FileMode.Open));
            */
            FileStream str1 = new FileStream(@"StreamBin.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(str1, str);
            str1.Close();
            FileStream strD = new FileStream(@"StreamBin.bin", FileMode.Open);
            BinaryFormatter ds = new BinaryFormatter();
            ClassBinary result = ds.Deserialize(strD) as ClassBinary;

            Console.WriteLine("Запись цифры " + class1.EnterNumer + " в бинарный файл завершен");


        }
    }
}
