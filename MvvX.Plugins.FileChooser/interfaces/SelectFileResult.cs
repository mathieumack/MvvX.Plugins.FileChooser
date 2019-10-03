namespace MvvX.Plugins.FileChooser
{
    public class SelectFileResult
    {
        /// <summary>
        /// Get full file path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets the size, in bytes, of the current file.
        /// </summary>
        public long FileSize { get; set; }
    }
}
