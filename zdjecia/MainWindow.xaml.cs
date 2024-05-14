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
using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace zdjecia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> paths = new List<string>();
        private BitmapImage displayedImage;
        private int displayedImageIndex = 0;
        private Rotation rotation = 0;
        private int size = 100;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void WybierzFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;  
            DialogResult result = dialog.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK) 
            {
                paths.Clear();  
                paths.AddRange(Directory.EnumerateFiles(dialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly).Where(s =>s.EndsWith(".jpg") || s.EndsWith(".png")));

                if(paths.Count > 0) 
                {

                }
            }
        }
    }
}