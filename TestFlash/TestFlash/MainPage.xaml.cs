using Android.Graphics;
using Java.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;



namespace TestFlash
{
    public partial class MainPage : ContentPage
    {
     
        public bool Toggle { get; set; } = true;
        

        public MainPage()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            if (Toggle)
            {
                flashOn.Source = ImageSource.FromFile("lightbulbon.png");
                await Flashlight.TurnOnAsync();
            Toggle = false;
            }
            else
            {
                flashOn.Source = ImageSource.FromFile("lightbulboff.png");
                await Flashlight.TurnOffAsync();
                Toggle= true;
            }
         
        }

       
    }
}
