using System;
using System.Collections;
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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }
        private void addBottom_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(txtBox.Text);
            txtBox.Text = "";
        }

        private void removeBottom_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(txtBox.Text);
            txtBox.Text = "";
        }

        private void showBottom_Click(object sender, RoutedEventArgs e)
        {
            for (int a = 0; a <= arrayList.Count -1; a++) 
            {
                MessageBox.Show(arrayList[a].ToString()); 
            }
            txtBox.Text = "";
        }
    }
}
