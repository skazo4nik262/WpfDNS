using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDNS
{
    /// <summary>
    /// Логика взаимодействия для CpuWin.xaml
    /// </summary>
    public partial class CpuWin : Window
    {
        public Cpu SelectedComp { get; set; }
        public ObservableCollection<object> SelectedComps { get; set; } = new();
        public CpuWin()
        {
            InitializeComponent();
            DataContext = this;
            ObservableCollection<object> AllComps = MainWindow.GetInstance().Componenti;
            if (SelectedComps != null)
            {
                for (int i = 0; i < AllComps.Count; i++)
                    if (AllComps[i] is Cpu)
                        SelectedComps.Add((Cpu)AllComps[i]);
            }
            else MessageBox.Show("Chupapi munania");
        }
        private void Select(object sender, RoutedEventArgs e)
        {

            if (SelectedComp != null)
            {
                MainWindow.GetInstance().SelectedComps.Add(SelectedComp);
            }
            else MessageBox.Show("768fdjgkdjfg");
        }
    }
}