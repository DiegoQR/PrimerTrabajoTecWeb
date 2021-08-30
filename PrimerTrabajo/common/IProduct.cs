using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralClasses
{
    public interface IProduct
    {
        int Id { get; set; }
        string Title { get; set; }
        TimeSpan Duration { get; set; }
        string AccessLink { get; set; }

        void showHimself();
    }
}
