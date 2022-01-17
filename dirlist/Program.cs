using System;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace dirlist

{
    
    class Program
    {
        static void Main(string[] args)
        {
            intClass intC = new intClass();
            intC.TxTHello();
            intC.DirSearch = Console.ReadLine();
            intC.FileSearchR();
            intC.FileRekurs = Console.ReadLine();
            intC.Catalogi();
             string[] dirVis = Directory.GetDirectories(intC.DirSearch);
             string[] fileVis = Directory.GetFiles(intC.DirSearch, intC.FileRekurs);
           
            string saveD = JsonConvert.SerializeObject((dirVis, fileVis));
            File.WriteAllText("Direc.json", saveD);
            Program loadJsonD = JsonConvert.DeserializeObject<Program>(saveD);
            System.Console.Write(saveD);


        }

    }
}



















