using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharecterReplace
{
    public class FileOperation //Sınıf İçindeki Tüm Elemanları Static Yapmak İstersen Etiketle
    {
        public static string ReadAndReplace(string _path,string FileName,List<string> oldValue,List<string> newValue)
        {
            string path = _path;
            // string text = File.ReadAllText(path).Replace(oldValue, newValue);
            string text = File.ReadAllText(path,Encoding.Default); //Encoding Set UTF-8
            for (int i = 0; i < oldValue.Count; i++)  //Or New Value it doesnt matter
                text=text.Replace(oldValue[i], newValue[i]); //Replace Sonrası Mutlaka Tekrar Atama Yapılacak
            var newPath = string.Format($"C:\\Users\\HasanBerkErgun\\Desktop\\{FileName.Substring(0,FileName.Length-4)}Replace.txt");
            if (!File.Exists(newPath))
            {
                File.Create(newPath).Close();
                using (StreamWriter streamWriter = File.CreateText(newPath))
                    streamWriter.WriteLine(text);

            }
            //File.WriteAllText(path,text,Encoding.GetEncoding("iso-8859-9"));
            return text;
        }
    }
}
