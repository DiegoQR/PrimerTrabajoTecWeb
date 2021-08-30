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
            testArtist.Add(new Artist(4, "Michael Jackson"));
            testArtist.Add(new Artist(5, "AVICII"));
            testArtist.Add(new Artist(6, "Boney M."));
            testArtist.Add(new Artist(7, "Shakira"));
            testArtist.Add(new Artist(8, "Luis Fonsi"));
            testArtist.Add(new Artist(9, "Chayanne"));
            testArtist.Add(new Artist(10, "Luis Miguel"));

            return testArtist;
        }



        public static void SetUpMenus()
        {

            MenuPage principalMenu = new MenuPage("Principal", null);
            MenuPage adminMenu = new MenuPage("Opciones de Administrador", principalMenu);
            //Modificar menu para que muestre todos los artistas automaticamente
            MenuPage artistMenu = new MenuPage("Artistas", principalMenu);
            MenuPage newContentMenu = new MenuPage("Añadir nuevo contenido", adminMenu);
            MenuPage newArtistMenu = new MenuPage("Añadir nuevo artista", adminMenu);
            principalMenu.AddNextMenu(artistMenu);
            principalMenu.AddNextMenu(adminMenu);
            adminMenu.AddNextMenu(newContentMenu);
            adminMenu.AddNextMenu(newArtistMenu);
            principalMenu.EnterMenu();
        }

        static void Main(string[] args)
        {
            SetUpMenus();
        }
    }
}
