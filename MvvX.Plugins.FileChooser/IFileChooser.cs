using System.Collections.Generic;

namespace MvvX.Plugins.FileChooser
{
    public interface IFileChooser
    {
        /// <summary>
        /// Allow you to select one or more files on the device
        /// </summary>
        /// <param name="multiSelect"></param>
        /// <returns></returns>
        OpenFileResult OpenFiles(bool multiSelect);
    }
}
