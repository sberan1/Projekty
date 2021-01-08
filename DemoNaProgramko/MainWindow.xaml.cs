using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Threading;

namespace DemoNaProgramko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int counter;
        public int Counter
        {
            get { return counter; }
            set { counter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Counter"));
            }
           
        }
        private string vrtule;

        public string Vrtule
        {
            get { return vrtule; }
            set { vrtule = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vrtule"));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        static CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken ct;

        private void Button_Click_Prace(object sender, RoutedEventArgs e)
        {
            cts = new CancellationTokenSource();
            ct = cts.Token;
            Task.Run(
                () =>
                {
                    for(int i = 15; i > 0; i--)
                    {
                        Counter = i;
                        Thread.Sleep(1000);
                    }
                    cts.Cancel();
                });
        }
        private async Task<int> TocSeVrtuleAync()
        {
            int i = 0;

            await Task.Run(() =>
            {
                while (ct.IsCancellationRequested == false)
                {
                    i++;
                    Vrtule = "-";
                    Thread.Sleep(500);
                    Vrtule = "\\";
                    Thread.Sleep(500);
                    Vrtule = "|";
                    Thread.Sleep(500);
                    Vrtule = "/";
                    Thread.Sleep(500);
                }
            });
            return i;
        }
        private async void Button_Click_Vrtet(object sender, RoutedEventArgs e)
        {
            int i = await TocSeVrtuleAync();
            Vrtule = i.ToString();
            
        }
    }
}
