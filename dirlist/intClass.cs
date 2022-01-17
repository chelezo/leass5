using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dirlist
{

    class intClass
    {
        private string _DirSearch;
        private string _FileRekurs;
        


       
         
        public void Catalogi()
        {
            System.Console.WriteLine("Каталоги и файлы:");
        }
        public void TxTHello()
        {
            System.Console.WriteLine("Приветсвуем Вас. Ведите путь к папке напрмер С:\\\\");
        }
        public void FileSearchR()
        {
            System.Console.WriteLine("Для получения заданных типов файлов укажите тип например *.txt");
        }
        public string DirSearch
       {
           get { return _DirSearch; }
           set { _DirSearch = value; }
        }

        public string FileRekurs
        {
            get { return _FileRekurs; }
            set { _FileRekurs = value; }
        }
    }
}
