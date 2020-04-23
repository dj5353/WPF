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

namespace ToDo
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

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(txtbox.Text != "")
            {
                CheckBox chk = new CheckBox();
                chk.Content = txtbox.Text.ToString();
                listbox.Items.Add(chk);
                txtbox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Add Task");
            }
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            int index = listbox.Items.IndexOf(listbox.SelectedItem);
            if(index != -1)
            {
                if(txtbox1.Text == "")
                {
                    MessageBox.Show("Enter the Text");
                }
                else
                {
                    CheckBox chk = new CheckBox();
                    chk.Content = txtbox1.Text.ToString();
                    listbox.Items.RemoveAt(index);
                    listbox.Items.Insert(index, chk);
                    txtbox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Select Text");
                index = -1;
            }



        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox.Items.RemoveAt(listbox.Items.IndexOf(listbox.SelectedItem));

            }
            catch(Exception)
            {
                MessageBox.Show("Select Task");
            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            if(listbox.Items.Count.Equals(0))
            {
                MessageBox.Show("Empty List");
            }
            else
            {
                listbox.Items.Clear();
            }
        }
    }
}
