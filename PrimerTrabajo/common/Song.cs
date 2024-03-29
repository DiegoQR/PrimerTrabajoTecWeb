﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace GeneralClasses
{
    public class Song : IProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AccessLink { get; set; }
        public WebController WebAccess { get; set; }
        private const string Type = "Song";

        //Interface Methods

        public void ReproduceMedia()
        {
            WebAccess = new WebController { AccessURL = AccessLink };
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Reproduciendo...");
            WebAccess.OpenWebPage();
            Console.BackgroundColor = ConsoleColor.Black;   
        }

        
    }
}
