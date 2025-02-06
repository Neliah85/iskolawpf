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
using System.IO;
using System.Diagnostics;

namespace iskolawpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<tanulo> tanulolist = new List<tanulo>();
        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("nevek.txt");
            while (!sr.EndOfStream)
            {
                tanulolist.Add(new tanulo(sr.ReadLine()));
            }
            sr.Close();
            //kiír mindenikit hány fő
            /*
            foreach (var item in tanulolist)
            {
                lista.Items.Add(item.ToString());
            }
            */
            lista.ItemsSource = tanulolist;
            lista.Items.Refresh();

        }

        private void Torles_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = lista.SelectedIndex;
                tanulolist.RemoveAt(index);
                lista.Items.Refresh();

            }
            catch (Exception)
            {

                MessageBox.Show("Nincs semmi kijelölve!");
            }
           


        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("neveknew.txt");
            
            foreach (var item in tanulolist)
            {
                sw.WriteLine(item.ToString());
            }
            
    
            sw.Close();
            Process.Start("neveknew.txt");


        }
    }
}
