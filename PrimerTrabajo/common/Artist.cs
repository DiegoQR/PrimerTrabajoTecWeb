using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Artist(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
