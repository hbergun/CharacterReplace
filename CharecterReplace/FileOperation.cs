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
        public static string ReadFromFile(string _path,char[] oldValue,char[] newValue)
        {
            string path = _path;
            // string text = File.ReadAllText(path).Replace(oldValue, newValue);
            string text = File.ReadAllText(path);
            for (int i = 0; i < oldValue.Length; i++) //Or New Value it doesnt matter
                text.Replace(oldValue[i],newValue[i]);
            File.WriteAllText(path, text);
            return text;
        }
    }
}
