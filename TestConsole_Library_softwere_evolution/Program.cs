﻿using System;
using System.IO;
using Library_Softwere_evolution;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole_Library_softwere_evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "BillInfo.yaml";
            if (args.Length == 1)
            {
                filename = args[0];
            }
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            YAMLFile _yamlfile = new YAMLFile();
            IPresenter p = new TXTPresenter();
            Bill b = _yamlfile.CreateBill(sr, p);
            Console.WriteLine(b.statement());
            Console.ReadKey();
        }
    }
}
