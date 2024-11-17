using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace egzWet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            string[] animals = { "Pies", "Kot", "Świnka morska" };
            InitializeComponent();
            animalsList.ItemsSource = animals;
            animalsList.HeightRequest = animals.Length * animalsList.RowHeight;
        }

        private void SelectAnimal(object sender, SelectedItemChangedEventArgs e)
        {
            if (animalsList.SelectedItem == "Świnka morska")
            {
                slider.Maximum = 9;
            }
            if (animalsList.SelectedItem == "Pies")
            {
                slider.Maximum = 18;
            }
            if (animalsList.SelectedItem == "Kot")
            {
                slider.Maximum = 20;
            }
        }

        private void AgeValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)slider.Value;
            ageLbl.Text = value.ToString();
        }

        private void Submit(object sender, EventArgs e)
        {
            DisplayAlert("Zapisana wizyta", name.Text + ", " + animalsList.SelectedItem + ", " + ageLbl.Text + ", " + goal.Text + ", " + time.Time, "OK");
        }
    }
}
