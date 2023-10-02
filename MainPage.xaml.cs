    using System;
    using Microsoft.Maui.Controls;
    using System.Collections.ObjectModel;

    namespace MauiApp1_hw
    {

        public partial class MainPage : ContentPage
        {
            public ObservableCollection<Goods> Goods { get; set;  }

            public MainPage()
            {
                InitializeComponent();
                Goods = new ObservableCollection<Goods>();
                BindingContext = this;
            }

            private void Add_Clicked(object sender, EventArgs e)
            {
                // Додати новий товар в список 
            }

            private void Remove_Clicked(object sender, EventArgs e)
            {
                // Видалити обраний товар зі списку 
            }
        }

    }