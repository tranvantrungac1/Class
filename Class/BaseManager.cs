﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class BaseManager
    {
        
        public static String VERSION = "1.0.0";
        private String name;
        public BaseManager(string name)
        {
            //console.writeline("init basemanager with name");
            //this.name = name;
        }

        public BaseManager()
        {
            //Console.WriteLine("Init BaseManager");
            //this.name = "Unknow";
        }

        virtual public void AddNew()
        {
            Console.WriteLine("Add New");
        }
        virtual public void Update()
        {
            Console.WriteLine("Remove");
        }
        virtual public void Delete()
        {
            Console.WriteLine("Delete");
        }
        virtual public void Find()
        {
            Console.WriteLine("Find");
        }
        virtual public int Login()
        {
            return 0;
        }
        virtual public void Import()
        {
            Console.WriteLine("Import");
        }
        virtual public void Export()
        {
            Console.WriteLine("Export");
        }
    }
}
