using System.Collections.Generic;

namespace MvvX.Plugins.FileChooser
{
    public class OpenFileResult
    {
        /// <summary>
        /// If the user clicks the OK button of the dialog that is displayed, true is returned; otherwise, false.
        /// </summary>
        public bool? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IList<SelectFileResult> SelectedFiles { get; set; }
    }
}
