using System.Windows;

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Class2 db = new Class2();
        public MainWindow()
        {
            InitializeComponent();
            db.CreateStrConnection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGetQuate_Click(object sender, RoutedEventArgs e)
        {
           
            Quote qoute = new Quote();

            qoute = qoute.GetQuote();

            lblQuate.Text = qoute.quoteText;
            lblAutor.Text = qoute.quoteAuthor;
            lblLink.Text = qoute.quoteLink;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            db.Addquote(lblQuate.Text, lblAutor.Text, lblLink.Text);
            MessageBox.Show("Добавлена в избранное");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 taskwindow = new Window1();
            taskwindow.Show();
            this.Hide();
        }
    }
}
