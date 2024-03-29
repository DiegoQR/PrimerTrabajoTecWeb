﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralClasses
{
    public class MenuPage
    {
        protected MenuPage PreviousMenu;
        protected List<MenuPage> NextMenus;
        protected string NameMenuOption;

        public MenuPage(string nameMenuOption, MenuPage previousMenu)
        {
            this.NameMenuOption = nameMenuOption;
            this.PreviousMenu = previousMenu;
            this.NextMenus = new List<MenuPage>();
        }

        public void AddNextMenu(MenuPage menu)
        {
            NextMenus.Add(menu);
        }

        //Interaction Methods

        protected void DisplayTitle()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(this.NameMenuOption);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public virtual void DisplayOptions()
        {
            this.DisplayTitle();
            int i = 1;
            foreach(MenuPage menu in NextMenus)
            {
                Console.WriteLine($"{i}: {menu.NameMenuOption}");
                i++;
            }
            Console.WriteLine("0: Salir");

        }

        protected void DisplayBadSelectionMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public virtual void EnterMenu()
        {
            bool isValid;
            int validInput;
            do
            {
                Console.Clear();
                this.DisplayOptions();
                string input = Console.ReadLine();
                isValid = this.ValidateInput(input, out validInput);
                if (!isValid)
                {
                    DisplayBadSelectionMessage("La opcion Ingresada no es valida, presione cualquier tecla para continuar...");
                }
            } while (!isValid);
            MenuPage menuSelected = this.RedirectMenu(validInput);
            if (menuSelected != null) { menuSelected.EnterMenu(); }
        }

        protected bool ValidateInput(string input, out int validatedInput)
        {
            int numbInput;
            bool isNumber = Int32.TryParse(input, out numbInput);
            bool isInRange = numbInput >= 0 && numbInput <= NextMenus.Count();
            validatedInput = numbInput;
            return isNumber && isInRange;
        }

        protected virtual MenuPage RedirectMenu(int optionSelected)
        {
            MenuPage menuSelected;
            if (optionSelected == 0)
            {
                menuSelected = PreviousMenu;
            }
            else
            {
                menuSelected = NextMenus[optionSelected - 1];
            }
            return menuSelected;
        }

    }
}