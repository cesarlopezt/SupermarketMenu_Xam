using SupermarketMenuPage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SupermarketMenuPage.ViewModels
{
    class MenuViewModel: INotifyPropertyChanged
    {
        public MenuItem  GeneralItem { get; }
        public MenuItem  BabiesItem { get; }
        public MenuItem  ClothesItem { get; }
        public MenuItem  CelebrationItem { get; }
        public MenuItem  PetsItem { get; }
        public MenuItem CleaningItem { get; }

        public MenuViewModel()
        {
            GeneralItem = new MenuItem("All", "1400 items", "cart");
            BabiesItem = new MenuItem("Baby Items", "200 items", "child");
            ClothesItem = new MenuItem("Clothes", "500 items", "clothes");
            CelebrationItem = new MenuItem("Party Supplies", "250 items", "party");
            PetsItem = new MenuItem("Pet Items", "150 items", "pets");
            CleaningItem = new MenuItem("Cleaning Items", "300 items", "cleaning");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
