using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{
    public class Podcast : IProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AccessLink { get; set; }
        public WebController WebAccess { get; set; }
        private const string Type = "Podcast";

        public void ReproduceMedia()
        {
            WebAccess = new WebController { AccessURL = AccessLink };
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Reproduciendo Podcast...");
            WebAccess.OpenWebPage();
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
