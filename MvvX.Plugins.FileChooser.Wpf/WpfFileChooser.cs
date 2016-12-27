using Microsoft.Win32;
using System.IO;
using System.Linq;

namespace MvvX.Plugins.FileChooser.Wpf
{
    public class WpfFileChooser : IFileChooser
    {
        public OpenFileResult OpenFiles(bool multiSelect)
        {
            var fileDialog = new OpenFileDialog();

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
    }
}
