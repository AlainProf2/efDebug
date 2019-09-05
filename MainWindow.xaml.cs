using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
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

namespace efDebug
{

    //public class Proprietaire
    //{
    //    public int ProprietaireId { get;set; }
    //    [MaxLength(50)]
    //    public string Nom { get; set; }
    //}
//    public class MiniContexte
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //BourseContexte bourseContexte = new BourseContexte();
        public MainWindow()
        {
            InitializeComponent();
            Outil outil = new Outil();
            //initContexte();
           
         }
       
        private void insertion()
        {
            Proprietaire mrX = new Proprietaire();
            mrX.Nom = "Albert";
            mrX.Naissance = DateTime.Now;
            mrX.Liquidite = 10000;
            Outil.BrsCtx.Groupe.Add(mrX);

            mrX = new Proprietaire();
            mrX.Nom = "Benoit";
            mrX.Naissance = DateTime.Now;
            mrX.Liquidite = 20000;
            Outil.BrsCtx.Groupe.Add(mrX);

            mrX = new Proprietaire();
            mrX.Nom = "Claudio";
            mrX.Naissance = DateTime.Now;
            mrX.Liquidite = 30000;
            Outil.BrsCtx.Groupe.Add(mrX);

            Outil.BrsCtx.SaveChanges();
        }

        private void insertion(object sender, RoutedEventArgs e)
        {
            insertion();
            MessageBox.Show("Insertion complétée");
        }

        private void recuperation(object sender, RoutedEventArgs e)
        {

        }

        private void modifier(object sender, RoutedEventArgs e)
        {

        }

        private void supprimer(object sender, RoutedEventArgs e)
        {

        }
    }
}
