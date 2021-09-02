using System.Diagnostics;
using System.Collections.Generic;
using GeneralClasses;
using System.Runtime.InteropServices;

namespace PrimerTrabajo
{
    class Program
    {


        public static List<Artist> PopulateArtists()
        {
            var testArtist = new List<Artist>();

            testArtist.Add(new Artist() { Id = 1, Name = "Queen" });
            testArtist[0].AddProduct(new Song { Id = 1, Title = "Don't Stop Me Now", AccessLink = "https://youtu.be/HgzGwKwLmgM" });
            testArtist[0].AddProduct(new Song { Id = 2, Title = "Radio Ga Ga", AccessLink = "https://youtu.be/azdwsXLmrHE" });
            testArtist[0].AddProduct(new Song { Id = 3, Title = "Bohemian Rhapsody", AccessLink = "https://youtu.be/fJ9rUzIMcZQ" });
            testArtist.Add(new Artist() { Id = 2, Name = "Guns N' Roses" });
            testArtist[1].AddProduct(new Song { Id = 1, Title = "Sweet Child O' Mine", AccessLink = "https://youtu.be/1w7OgIMMRc4" });
            testArtist[1].AddProduct(new Song { Id = 2, Title = "November Rain", AccessLink = "https://youtu.be/8SbUC-UaAxE" });
            testArtist[1].AddProduct(new Song { Id = 3, Title = "Welcome To The Jungle", AccessLink = "https://youtu.be/o1tj2zJ2Wvg" });
            testArtist.Add(new Artist() { Id = 3, Name = "Chayanne" });
            testArtist[2].AddProduct(new Song { Id = 1, Title = "Torero", AccessLink = "https://youtu.be/GuZzuQvv7uc" });
            testArtist[2].AddProduct(new Song { Id = 2, Title = "Humanos a Marte", AccessLink = "https://youtu.be/4s9EJLHZdH8" });
            testArtist.Add(new Artist() { Id = 4, Name = "Boney M." });
            testArtist[3].AddProduct(new Song { Id = 1, Title = "Ma Baker", AccessLink = "https://youtu.be/9c5yPIQ3LQI" });
            testArtist[3].AddProduct(new Song { Id = 2, Title = "Rivers of Babylon", AccessLink = "https://youtu.be/l3QxT-w3WMo" });
            testArtist[3].AddProduct(new Song { Id = 3, Title = "Rasputin ", AccessLink = "https://youtu.be/16y1AkoZkmQ" });
            testArtist.Add(new Artist() { Id = 5, Name = "Rick Astley" });
            testArtist[4].AddProduct(new Song { Id = 1, Title = "Never Gonna Give You Up ", AccessLink = "https://youtu.be/dQw4w9WgXcQ" });
            testArtist[4].AddProduct(new Song { Id = 2, Title = "Together Forever", AccessLink = "https://youtu.be/yPYZpwSpKmA" });
            testArtist.Add(new Artist() { Id = 6, Name = "TOTO" });
            testArtist[5].AddProduct(new Song { Id = 1, Title = "Africa", AccessLink = "https://youtu.be/FTQbiNvZqaY" });
            testArtist[5].AddProduct(new Song { Id = 2, Title = "Hold The Line", AccessLink = "https://youtu.be/htgr3pvBr-I" });
            testArtist[5].AddProduct(new Song { Id = 3, Title = "Rosanna", AccessLink = "https://youtu.be/qmOLtTGvsbM" });
            testArtist.Add(new Artist() { Id = 7, Name = "Michael Jackson" });
            testArtist[6].AddProduct(new Song { Id = 1, Title = "Billie Jean", AccessLink = "https://youtu.be/Zi_XLOBDo_Y" });
            testArtist[6].AddProduct(new Song { Id = 2, Title = "Smooth Criminal", AccessLink = "https://youtu.be/T7PL3rmUhDI" });
            testArtist[6].AddProduct(new Song { Id = 3, Title = "Thriller", AccessLink = "https://youtu.be/4V90AmXnguw" });
            testArtist[6].AddProduct(new Song { Id = 4, Title = "Bad ", AccessLink = "https://youtu.be/dsUXAEzaC3Q" });
            testArtist.Add(new Artist() { Id = 8, Name = "Luis Miguel" });
            testArtist[7].AddProduct(new Song { Id = 1, Title = "Ahora te puedes marchar", AccessLink = "https://youtu.be/yG7MPEQm1-w" });
            testArtist.Add(new Artist() { Id = 9, Name = "The Beatles" });
            testArtist[8].AddProduct(new Song { Id = 1, Title = "Here Comes The Sun", AccessLink = "https://youtu.be/KQetemT1sWc" });
            testArtist[8].AddProduct(new Song { Id = 2, Title = "Help!", AccessLink = "https://youtu.be/2Q_ZzBGPdqE" });
            testArtist[8].AddProduct(new Song { Id = 3, Title = "Lucy In The Sky With Diamonds", AccessLink = "https://youtu.be/naoknj1ebqI" });
            //Prueba Podcast
            testArtist.Add(new Artist() { Id = 10, Name = "Neil deGrasse" });
            testArtist[9].AddProduct(new Podcast { Id = 1, Title = "Neil deGrasse Tyson Explains Hot Potatoes", AccessLink = "https://youtu.be/8GiduQuIlG4" });
            testArtist[9].AddProduct(new Podcast { Id = 2, Title = "Neil deGrasse Tyson Explains Burning Stuff", AccessLink = "https://youtu.be/nE9ep4WnsA4" });
            testArtist[9].AddProduct(new Podcast { Id = 3, Title = "Neil deGrasse Tyson Explains the Sun", AccessLink = "https://youtu.be/apRVqNc4UhE" });


            return testArtist;
        }

        public static void CreateArtistMenu(ref MenuPage artistMenu)
        {
            var listArtist = PopulateArtists();
            foreach (Artist artist in listArtist)
            {
                MenuPage songsMenu = new MenuPage(artist.Name, artistMenu);
                foreach(IProduct product in artist.Products)
                {
                    //Cambiar para que haga acciones en lugar de redirigir a otro menu 
                    MenuPage singleSongMenu = new ActionMenu(product.Title, songsMenu, product.ReproduceMedia);
                    songsMenu.AddNextMenu(singleSongMenu);
                }
                artistMenu.AddNextMenu(songsMenu);
            } 
        }

        public static void SetUpMenus()
        {

            MenuPage principalMenu = new MenuPage("Principal", null);
            //Modificar menu para que muestre todos los artistas automaticamente
            MenuPage artistMenu = new MenuPage("Artistas", principalMenu);
            CreateArtistMenu(ref artistMenu);
            principalMenu.AddNextMenu(artistMenu);
            principalMenu.EnterMenu();
        }


        static void Main(string[] args)
        {
            SetUpMenus();
        }
    }
}
