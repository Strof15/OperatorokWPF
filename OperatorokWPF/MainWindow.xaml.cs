using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
namespace OperatorokWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        public void inditogomb_Click(object sender, RoutedEventArgs e)
        {
            List<Operatorok> adatoklistaja = new List<Operatorok>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            File.ReadAllLines(openFileDialog.FileName).ToList().ForEach(x => adatoklistaja.Add(new Operatorok(x))) ;
       
           
            //2. feladat
            eredmenylbl.Content = adatoklistaja.Count();
            //3.feladat

            //4.feladat
            
            // eredmenylbl.Content =
            
        }

        public void feladatmegoldogomb_Click(object sender, RoutedEventArgs e)
        {
           
          
           
        }
    }
}
