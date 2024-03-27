using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace zdjecia
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
        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LoadImagesFromFolder(string folderPath)
        {
            ImageListView.Items.Clear();

            List<BitmapImage> images = new List<BitmapImage>();
            foreach (string imagePath in Directory.GetFiles(folderPath, "*.jpg"))
            {
                BitmapImage image = new BitmapImage(new Uri(imagePath));
                images.Add(image);
            }

            ImageListView.ItemsSource = images;
        }
        private void WybierzFolder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}