using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MvvX.Plugins.FileChooser.Wpf
{
    public class WpfFileChooser : IFileChooser
    {
        public OpenFileResult OpenFiles(bool multiSelect)
        {
            var fileDialog = new Microsoft.Win32.OpenFileDialog();

            fileDialog.Multiselect = multiSelect;

            var result = fileDialog.ShowDialog();
            if(result.HasValue && result.Value && fileDialog.FileNames != null)
            {
                return new OpenFileResult()
                {
                    Result = true,
                    SelectedFiles = fileDialog.FileNames.Select(e => new SelectFileResult()
                    {
                        FilePath = e,
                        FileSize = new FileInfo(e).Length
                    }).ToList()
                };
            }
            
            return new OpenFileResult()
            {
                Result = false
            };
        }


        public OpenFolderResult OpenFolder()
        {
            var fileDialog = new FolderBrowserDialog();
            
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                return new OpenFolderResult()
                {
                    Result = true,
                    SelectedPath = fileDialog.SelectedPath
                };
            }

            return new OpenFolderResult()
            {
                Result = false
            };
        }
    }
}
