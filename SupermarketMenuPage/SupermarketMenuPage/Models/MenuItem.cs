using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketMenuPage.Models
{
    class MenuItem
    {
        public MenuItem(string title, string description, string image)
        {
            Title = title;
            Description = description;
            Img = image;
        }
        public string Title { get; }
        public string Description { get; }
        public string Img { get; }
    }
}
