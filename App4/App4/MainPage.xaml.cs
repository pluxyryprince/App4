using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Submit_Clicked(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(First.Text);
                int b = Convert.ToInt32(Second.Text);

                int result = a + b;

                Page1 secondpage = new Page1();
                Navigation.PushAsync(secondpage);
                secondpage.Calculator(result);
            }
            catch (FormatException)
            {
                DisplayAlert("Ошибка", "Ошибка введенных данных!", "Ввести заново");
            }
        }
    }

}