using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Library_Softwere_evolution;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWPF_Library_Softwere_evolution
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string path = null;

        private void ButtonSet_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
           // ofd.Filter = "Text Document (.txt)|*.txt";
            if(ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
                Tb_filepath.Text = path;
            }
        }

        private void But_Print_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                YAMLFile _yamlfile = new YAMLFile();
                IPresenter p = null;
                if (Rb_TXT.IsChecked == true)
                {
                  p = new TXTPresenter();
                }
                if(Rb_HTML.IsChecked == true)
                {
                 p = new HTMLPresenter();
                }
                Bill b = _yamlfile.CreateBill(sr, p);
                Tblock1.Text = b.statement();
                fs.Close();
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Выберите файл...");
            }
        }

        private void But_Clear_Click(object sender, RoutedEventArgs e)
        {
            Tblock1.Text = "";
        }
    }
}
