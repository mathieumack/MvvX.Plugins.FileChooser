using MvvmCross.Platform;
using MvvmCross.Platform.Plugins;

namespace MvvX.Plugins.FileChooser.Wpf
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<IFileChooser>(() =>
            {
                return new WpfFileChooser();
            });
        }
    }
}
