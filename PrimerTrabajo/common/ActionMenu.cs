using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{
    public class ActionMenu : MenuPage
    {
        private Action ActionToDo;

        public ActionMenu(string nameMenuOption, MenuPage previousMenu, Action actionToDo) : base(nameMenuOption, previousMenu) 
        {
            this.ActionToDo = actionToDo;
        }

        public override void DisplayOptions()
        {
            this.ActionToDo();
            base.DisplayOptions();
        }

    }
}
