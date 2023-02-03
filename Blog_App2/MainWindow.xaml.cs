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

namespace Blog_App2
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

        private void btnCreatePost_Click(object sender, RoutedEventArgs e)
        {
            // get the value from our Header TextBox
            // get the value from our Body Run
            string header = txtHeader.Text;
            string body = runBody.Text;

            // create a new BlogPost object
            BlogPost bp = new BlogPost(header, body);

            // display in our runDisplay by:
            // Calling our post method to return a formatted post string
            // Assign it to our runDisplay
            runDisplay.Text = bp.Post();

        }
    }
}
