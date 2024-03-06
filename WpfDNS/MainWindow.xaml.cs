using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
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
using WpfDNS.Wins;

namespace WpfDNS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<object> Componenti { get; set; } = new();
        public ObservableCollection<object> SelectedComps { get; set; } = new();
        public Cpu SelectedCpu { get; set; }
        public Gpu SelectedGpu { get; set; }
        public Ram SelectedRam { get; set; }
        public Ssd SelectedSsd { get; set; }
        public MainWindow()
        {
            Componenti.Add(new Cpu { Name = "i123", Chastota= 1, TDP= 100, Cost=100});
            Componenti.Add(new Gpu { Name = "i123", Chastota = 1, Cost = 0, VRAM=123 });
            Componenti.Add(new Ram { Name = "i123", Chastota = 1, Obiom =1000, Cost = 2999 });
            Componenti.Add(new Ssd { Name = "i123", Memory = 123, Speedoz= 299999, Cost = 5000 });
            InitializeComponent();
            DataContext = this;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedComps)));


        }

        
        public class Components
        {
            public Cpu CPU { get; set; }
            public Gpu GPU { get; set; }
            public Ram RAM { get; set; }
            public Ssd SSD { get; set; }
        }

        private static MainWindow instance;

        public event PropertyChangedEventHandler? PropertyChanged;

        public static MainWindow GetInstance()
        { if (instance == null) { instance = new MainWindow(); } return instance; }

        private void SelectCpu_Click(object sender, RoutedEventArgs e)
        {
            CpuWin cpuWin = new CpuWin();
            cpuWin.Show();
        }

        private void SelectGpu_Click(object sender, RoutedEventArgs e)
        {
            GpuWin gpuWin = new GpuWin();
            gpuWin.Show();
        }

        private void SelectRam_Click(object sender, RoutedEventArgs e)
        {
            RamWin ramWin = new RamWin();
            ramWin.Show();
        }

        private void SelectSsd_Click(object sender, RoutedEventArgs e)
        {
            SsdWin ssdWin = new SsdWin();
            ssdWin.Show();
        }

    }
}
