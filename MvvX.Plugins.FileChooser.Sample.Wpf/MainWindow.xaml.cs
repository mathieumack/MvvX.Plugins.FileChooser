using MvvX.Plugins.FileChooser.Wpf;
using System.Linq;
using System.Windows;

namespace MvvX.Plugins.FileChooser.Sample.Wpf
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

        private void btnFiles_Click(object sender, RoutedEventArgs e)
        {
            IFileChooser fileChooser = new WpfFileChooser();

            var result = fileChooser.OpenFiles(chkMultipleFileSelection.IsChecked.Value);
            if (result.Result.Value)
            {
                var files = string.Join(System.Environment.NewLine, result.SelectedFiles.Select(f => f.FilePath + " (" + f.FileSize + ")"));
                MessageBox.Show(result.SelectedFiles.Count + " file(s) selected." + System.Environment.NewLine + files);
            }
            else
                MessageBox.Show("Operation canceled");
        }

        private void btnFolder_Click(object sender, RoutedEventArgs e)
        {
            IFileChooser fileChooser = new WpfFileChooser();

            var result = fileChooser.OpenFolder();
            if (result.Result.Value)
            {
                MessageBox.Show("1 folder selected." + System.Environment.NewLine + result.SelectedPath);
            }
            else
                MessageBox.Show("Operation canceled");
        }
    }
}
