using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WPF.Ko.Common.Models;

namespace WPF.Ko;
public class MainWindowViewModel : INotifyPropertyChanged
{
    private List<string> _themes;

    public List<string> Themes
    {
        get { return _themes; }
        set { _themes = value; }
    }

    private string _selectedTheme;

    public string SelectedTheme
    {
        get { return _selectedTheme; }
        set
        {
            _selectedTheme = value;
            ChangeTheme();
        }
    }


    private Alcohol selectedAlcohol = new();

    public ObservableCollection<Alcohol> Alcohols { get; set; } = new ObservableCollection<Alcohol>();
    public Alcohol SelectedAlcohol
    {
        get { return selectedAlcohol; }
        set
        {
            selectedAlcohol = value;
            OnPropertyChanged("selectedAlcohol");
        }
    }

    public MainWindowViewModel()
    {
        Alcohols =
            [
                new Alcohol { Id = 1, Type = AlcoholType.EmptyAlcoholType, AveragePrice = 0 },
                new Alcohol { Id = 2, Type = AlcoholType.WhiskyType, AveragePrice = 200 },
                new Alcohol { Id = 3, Type = AlcoholType.WhiskeyType, AveragePrice = 100 },
                new Alcohol { Id = 4, Type = AlcoholType.CognacType, AveragePrice = 150}
            ];
        _themes = ["Light", "Dark"];
        _selectedTheme = Themes.First();
    }

    private void ChangeTheme()
    {
        ResourceDictionary dictionary = new();
        var uri = _selectedTheme.Equals("Dark") ?
            "/WPF.Ko.ResourceLibrary;component/Themes/Dark/DarkThemeBase.xaml"
            : "/WPF.Ko.ResourceLibrary;component/Themes/Light/LightThemeBase.xaml";
        dictionary.Source = new Uri(uri, UriKind.RelativeOrAbsolute);
        Application.Current.Resources.Clear();
        Application.Current.Resources.MergedDictionaries.Add(dictionary);
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}