using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
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

namespace WpfDNS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Componenti { get; set; } = new List<string>();
        public MainWindow()
        {
            //Componenti.Add(new Cpu { Name = "i9", Chastota = 1, TDP = 1000000});
            Componenti.Add(new string("CPU"));
            Componenti.Add(new string("GPU"));
            Componenti.Add(new string("RAM"));
            Componenti.Add(new string("SSD"));
            Componenti.Add(new string("WIFI"));
            Componenti.Add(new string("MOTHER"));
            InitializeComponent();
            DataContext = this;

        }
        public class Ikonka
        {
            public byte[] Image { get; set; }
        }
        public class Components
        {
            public Cpu CPU { get; set; }
            public Gpu GPU { get; set; }
            public Ram RAM { get; set; }
            public Ssd SSD { get; set; }
            public Wifi WIFI { get; set; }
            public Mother MOTHER { get; set; }
        }

        private void SelectCpu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectGpu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectRam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectSsd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectWifi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SelectMother_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
