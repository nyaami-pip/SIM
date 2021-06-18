﻿using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SimbirSoft_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Press any key to Start");
            Console.ReadKey();
            Program program = new Program();
            program.Start();
            Console.WriteLine("Press any key to Escape");
            Console.ReadKey();
        }
        public void Start()
        {
            FileWorker fileWorker = new FileWorker();
            HTMLWorker htmlWorker;
            WordWorker wordWorker;
            var urldata = fileWorker.ReadFile();
            Console.WriteLine(urldata);
            htmlWorker = new HTMLWorker(urldata);
            htmlWorker.SaveHTMLPages();
            wordWorker = new WordWorker(urldata);
            wordWorker.Work();
        }
    }
}
