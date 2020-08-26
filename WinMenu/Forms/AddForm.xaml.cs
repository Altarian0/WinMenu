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
using WinMenu.Database;
using WinMenu.Helper;

namespace WinMenu.Forms
{
    /// <summary>
    /// Interaction logic for AddForm.xaml
    /// </summary>
    public partial class AddForm : Window
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

            if (FileRB.IsChecked == true)
            {
                File file = new File
                {
                    Title = NameText.Text,
                    Size = Decimal.Parse(SizeText.Text)
                };

                DBHelper.GetContext().File.Add(file); 
            }
            if (FolderRB.IsChecked == true)
            {
                Folder folder = new Folder
                {
                    Title = NameText.Text,
                };
                DBHelper.GetContext().Folder.Add(folder);
            }

            DBHelper.GetContext().SaveChanges();
            this.Close();
        }

        private void SizeText_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = ".0123456789".IndexOf(e.Text) < 0;
        }
    }
}
