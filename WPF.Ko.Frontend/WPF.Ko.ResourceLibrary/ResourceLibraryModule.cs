using System.Windows;

namespace WPF.Ko.ResourceLibrary
{
    public class ResourceLibraryModule
    {
        public ResourceLibraryModule()
        {
            RegisterResources();
        }

        private static void RegisterResources()
        {
            ResourceDictionary dictionary = new();
            dictionary.Source = new Uri("/WPF.Ko.ResourceLibrary;component/Themes/Light/LightThemeBase.xaml", UriKind.RelativeOrAbsolute);
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
