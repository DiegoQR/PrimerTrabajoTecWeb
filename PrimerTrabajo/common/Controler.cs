using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{

    public class Controler
    {
        public List<Action> DisplayMenus;

        public Controler(List<Action> displayMenues)
        {
            this.DisplayMenus = displayMenues;
        }

        public Action RedirectMenus(int input, Action actualMenu)
        {
            Action nextMenu = null;
            if (actualMenu == DisplayMenus[0])// Its in principal menu
            {
                switch(input) 
                {
                    case 0: 
                        nextMenu = null;
                        break;
                    case 1:
                        nextMenu = DisplayMenus[1];
                        break;
                    case 2:
                        nextMenu = DisplayMenus[2];
                        break;
                }
            }
            else if (actualMenu == DisplayMenus[1])// Its in artist menu
            {
                switch (input)
                {
                    case 0:
                        nextMenu = DisplayMenus[0];
                        break;
                }
            }
            else if (actualMenu == DisplayMenus[2])// Its in admin menu
            {
                switch (input)
                {
                    case 0:
                        nextMenu = DisplayMenus[0];
                        break;
                    case 1:
                        nextMenu = DisplayMenus[1];
                        break;
                    case 2:
                        nextMenu = DisplayMenus[2];
                        break;
                }
            }
            return nextMenu;
        }
    }
}
