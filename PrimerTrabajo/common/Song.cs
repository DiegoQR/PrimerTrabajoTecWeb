using System;
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
        private const string Type = "Song";

        //Interface Methods

        public void ReproduceMedia()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Reproduciendo...");
            this.OpenSong();
            Console.BackgroundColor = ConsoleColor.Black;   
        }

        public void OpenSong()
        {
            string url = this.AccessLink;
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
