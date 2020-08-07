using Newtonsoft.Json;
using SearchBook.Models;
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

namespace SearchBook
{
   
    public partial class MainWindow : Window
    {
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("D:/DEV/BackendTest/books.json"))
            {
                string json = r.ReadToEnd();

                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json); // criando a lista de objetos a partir do json

                listResultado.ItemsSource = books; // mostrar a lista de objetos por nome


                /*if (!string.IsNullOrEmpty(name.Text))
                {
                    if (name.Text.Contains(getname))
                    {
                        price.Text = "datebayo";
                    }
                }*/
            }
        }


        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e) // search
        {
            LoadJson();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // buy
        {
                       
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // clear
        {
            name.Text = "";
            price.Text = "";
            published.Text = "";
            author.Text = "";
            page.Text = "";
            illustrator.Text = "";
            genre.Text = "";

        }
    }
}
