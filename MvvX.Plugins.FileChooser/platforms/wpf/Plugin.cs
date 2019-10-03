using MvvmCross;
using MvvmCross.Plugin;

namespace MvvX.Plugins.FileChooser
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.RegisterType<IFileChooser>(() =>
            {
                return new WpfFileChooser();
            });
        }
    }
}
