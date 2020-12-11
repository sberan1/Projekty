using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xam1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xam1.View;

namespace Xam1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class PageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(AMan man)
        {
            FirstName = man.FirstName;
            Surname = man.Surname;
            Age = man.Age;
        }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
            }
        }
        private string _Surname;

        public string Surname
        {
            get { return _Surname; }
            set
            {
                _Surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname"));
            }
        }
        private int _Age;

        public int Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }
        public AMan ToAMan()
        {
            AMan am = new AMan
            {
                FirstName = this.FirstName,
                Surname = this.Surname,
                Age = this.Age
            };
        return am;
        }

    }
    }
    public partial class AManPage : ContentPage
    {
        ObservableCollection<AMan> oCollection;
        public AManPage()
        {
            InitializeComponent();
        }
        public AManPage(AMan m, ObservableCollection<AMan> collection)
        {
            InitializeComponent();
            PageViewModel pwm = new PageViewModel(m);
        BindingContext = pwm;
            oCollection = collection;
        }

        private void Save_Button_Clicked(object sender, EventArgs e)
        {
        oCollection.Add((BindingContext as PageViewModel).ToAMan());
        }
    }
