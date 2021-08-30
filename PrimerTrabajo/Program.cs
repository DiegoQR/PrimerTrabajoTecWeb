using System;
using System.Collections.Generic;
using GeneralClasses;

namespace PrimerTrabajo
{
    class Program
    {
        public static List<Artist> PopulateArtists()
        {
            var testArtist = new List<Artist>();

            testArtist.Add(new Artist(1, "Queen"));
            testArtist.Add(new Artist(2, "Metalica"));
            testArtist.Add(new Artist(3, "Bruno Mars"));
            testArtist.Add(new Artist(4, "Lil Nas X"));
            testArtist.Add(new Artist(5, "Michael Jackson"));
            testArtist.Add(new Artist(6, "deadmau5"));
            testArtist.Add(new Artist(7, "AVICII"));
            testArtist.Add(new Artist(8, "Boney M."));
            testArtist.Add(new Artist(9, "Shakira"));
            testArtist.Add(new Artist(10, "Luis Fonsi"));
            testArtist.Add(new Artist(11, "Chayanne"));
            testArtist.Add(new Artist(12, "Luis Miguel"));

            return testArtist;
        }

        static void Main(string[] args)
        {
            var testArtist = PopulateArtists();
            Principal principal = new Principal() { ArtistsList = testArtist, ProductsList = null};
            principal.ShowPrincipalPage();
        }
    }
}
