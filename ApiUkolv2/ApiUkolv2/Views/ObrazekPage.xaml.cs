﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.ObjectModel;
using ApiUkolv2.Model;
using Xamarin.Forms.Xaml;

namespace ApiUkolv2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObrazekPage : ContentPage
    {
        public ObrazekPage()
        {
            InitializeComponent();

        }
        public ObrazekPage(Obrazky vybranyObrazek)
        {
            InitializeComponent();
            BindingContext = vybranyObrazek;
        }
    }
}