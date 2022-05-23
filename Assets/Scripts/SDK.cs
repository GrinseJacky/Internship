using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts {
    class SDK : MonoBehaviour{

        static readonly string rootFolder = @"C:\Users\Dany\Desktop";   
  //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
        static readonly string textFile = @"C:\Users\Dany\Desktop\GIFT.txt";

        public void Start() {
            enscape(Read());
        }

        public static string Read() {
            
            if (File.Exists(textFile)) {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
                return text;
            }
            /*
            if (File.Exists(textFile)) {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }*/
            /*
            if (File.Exists(textFile)) {
                // Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(textFile)) {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null) {
                        Console.WriteLine(ln);
                        Debug.Log(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine("File has {counter} lines.");
                }
            }*/
            Console.ReadKey();
            return "";
            
        }

        public static String[] enscape(string text) {
            String[] spearator = { "::", "{"};

            String[] strlist = text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist) {
                Console.WriteLine(s);
                Debug.Log(s);
            }

            return strlist;
        }

    }
}
