﻿using System;
using Xamarin.Forms;

namespace AndroidXApp.Views.Image
{
    public partial class ImageFromPage : ContentPage
    {
        public ImageFromPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
	        await Navigation.PushAsync(new ImageToPage());
        }
    }
}
