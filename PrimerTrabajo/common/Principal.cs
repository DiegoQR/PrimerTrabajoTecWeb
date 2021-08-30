using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{
    public class Principal
    {
        public List<Artist> ArtistsList;
        public List<IProduct> ProductsList;
        public Controler MenuController;

        public Principal()
        {
            var menus = new List<Action>();

            menus.Add(ShowPrincipalPage);
            menus.Add(ShowListOfArtist);
            menus.Add(ShowAdministratorOptions);

            this.MenuController = new Controler(menus);
        }

        public void ShowAdministratorOptions()
        {
            Console.WriteLine("1: Añadir nuevo producto");
            Console.WriteLine("2: Crear Artista");
            Console.WriteLine("0: Salir");
        }

        public void ShowPrincipalPage()
        {
            int input;
            bool converted;
            do
            {
                Console.WriteLine("1: Mostrar Artistas");
                Console.WriteLine("2: Opciones de Administrador");
                Console.WriteLine("0: Salir");
                converted = Int32.TryParse(Console.ReadLine(), out input);
            } while (!converted || (input < 0  || input > 2));
            var nextMenu = MenuController.RedirectMenus(input, ShowPrincipalPage);
            nextMenu();
        }

        //Implement the rest of the artists
        public void ShowListOfArtist()
        {
            int i = 1;
            foreach (Artist artist in ArtistsList)
            {
                Console.WriteLine($"{i}: {artist.Name}");
                i++;
            }
            Console.WriteLine("0: Salir");
        }
    }
}
