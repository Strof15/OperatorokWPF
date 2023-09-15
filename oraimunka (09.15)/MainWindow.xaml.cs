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
//namespace operatorokwpf
namespace operatorokwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<OperatorokClass> kifejezesek = new List<OperatorokClass>();
        List<string> kimenetiSorok = new List<string>();
        public MainWindow()
        {
            InitializeComponent();


        }


        public void inditogomb_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == false)
            {
                MessageBox.Show("hibaüzenet");
            }
            else
            {
                File.ReadAllLines(openFileDialog.FileName).ToList().ForEach(x => kifejezesek.Add(new OperatorokClass(x)));

                lblfajlmegjelenito.Content = openFileDialog.FileName;

                //2. feladat

                lberedmeny.Items.Add($" 2. feladat: Kifejezések száma:{kifejezesek.Count()}");

                //3.feladat

                lberedmeny.Items.Add($" 3. feladat: Kifejezések maradékos osztásssal: {kifejezesek.Count(x => x.Operatorjel == "mod")}");

                //4.feladat

                lberedmeny.Items.Add(kifejezesek.Any(x => x.OperandusA % 10 == 0 && x.OperandusB % 10 == 0) ? "4. feladat: Van ilyen kifejezés" : "4. feladat: Nincs ilyen kifejezés");

                //5.feladat
                //Ez nagyobb darabszám esetén nem járható!
                lberedmeny.Items.Add($"5. feladat: Statisztika");
                lberedmeny.Items.Add($"mod -> {kifejezesek.Count(x => x.Operatorjel == "mod")} db");
                lberedmeny.Items.Add($"/ -> {kifejezesek.Count(x => x.Operatorjel == "/")} db");
                lberedmeny.Items.Add($"div -> {kifejezesek.Count(x => x.Operatorjel == "div")} db");
                lberedmeny.Items.Add($"- -> {kifejezesek.Count(x => x.Operatorjel == "-")} db");
                lberedmeny.Items.Add($"* -> {kifejezesek.Count(x => x.Operatorjel == "*")} db");
                lberedmeny.Items.Add($"+ -> {kifejezesek.Count(x => x.Operatorjel == "+")} db");
                //Helyes megoldás a szótár használata. Nem számít hányféle operátor van!
                /*
                Dictionary<string, int> muveletekSzama = new Dictionary<string, int>();

                foreach (var kifejezes in kifejezesek)
                {
                    if (muveletekSzama.Keys.Contains(kifejezes.Operatorjel)) //Ha a művelet még nincs a szótárban
                    {
                        muveletekSzama[kifejezes.Operatorjel]++; //meglévők számának növelés
                    }
                    else
                    {
                        muveletekSzama.Add(kifejezes.Operatorjel, 1); //új bejegyzés felvétele
                    }
                }

                foreach (var muvelet in muveletekSzama)
                {
                    lberedmeny.Items.Add($"\tművelet:{muvelet.Key} - db: {muvelet.Value}");
                }
                */


                //6.feladat
               

                //7.feladat


                //8.feladat

                

                
            }



        }

        private void adatbeviteltb_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void Szamologomb_Click(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void Mentesgomb_Click(object sender, RoutedEventArgs e)
        {
            
            //Az adatok betöltése a listába
            File.WriteAllLines("Hova_milyen_neven.txt", kimenetiSorok);
        }

    }
}
