using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WpfDNS.Wins
{
    /// <summary>
    /// Логика взаимодействия для GpuWin.xaml
    /// </summary>
    public partial class GpuWin : Window
    {
        public Gpu SelectedComp { get; set; }
        public ObservableCollection<object> SelectedComps { get; set; } = new();
        public GpuWin()
        {
            InitializeComponent();
            DataContext = this;
            ObservableCollection<object> AllComps = MainWindow.GetInstance().Componenti;
            if (SelectedComps != null)
            {
                for (int i = 0; i < AllComps.Count; i++)
                    if (AllComps[i] is Gpu)
                        SelectedComps.Add((Gpu)AllComps[i]);
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
