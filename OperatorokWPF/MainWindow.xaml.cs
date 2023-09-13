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
            List<Operator> adatoklistaja = new List<Operator>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == false)
            {
                MessageBox.Show("hibaüzenet");
            }
            else
            {
                File.ReadAllLines(openFileDialog.FileName).ToList().ForEach(x => adatoklistaja.Add(new Operator(x)));

                lblfajlmegjelenito.Content = openFileDialog.FileName;

                //2. feladat

                lberedmeny.Items.Add($" 2. feladat: Kifejezések száma:{adatoklistaja.Count()}");

                //3.feladat

                lberedmeny.Items.Add($" 3. feladat: Kifejezések maradékos osztásssal: {adatoklistaja.Count(x => x.Operatorjel == "mod")}");

                //4.feladat

                lberedmeny.Items.Add(adatoklistaja.First(x => x.OperandusA % 10 == 0 && x.OperandusB % 10 == 0) != null ? "4. feladat: Van ilyen kifejezés" : "4. feladat: Nincs ilyen kifejezés");

                //5.feladat
                lberedmeny.Items.Add($"5. feladat: Statisztika");
                lberedmeny.Items.Add($"mod -> {adatoklistaja.Count(x => x.Operatorjel == "mod")} db");
                lberedmeny.Items.Add($"/ -> {adatoklistaja.Count(x => x.Operatorjel == "/")} db");
                lberedmeny.Items.Add($"div -> {adatoklistaja.Count(x => x.Operatorjel == "div")} db");
                lberedmeny.Items.Add($"- -> {adatoklistaja.Count(x => x.Operatorjel == "-")} db");
                lberedmeny.Items.Add($"* -> {adatoklistaja.Count(x => x.Operatorjel == "*")} db");
                lberedmeny.Items.Add($"+ -> {adatoklistaja.Count(x => x.Operatorjel == "+")} db");
                //6.feladat

                //7.feladat

                //8.feladat
            }



        }

        public void feladatmegoldogomb_Click(object sender, RoutedEventArgs e)
        {



        }
    }
}
