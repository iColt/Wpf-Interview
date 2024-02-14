using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPF.Ko.Common.Models;

namespace WPF.Ko;
public class MainWindowViewModel : INotifyPropertyChanged
{
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
        Alcohols = new ObservableCollection<Alcohol>
            {
                new Alcohol { Id = 1, Type = AlcoholType.EmptyAlcoholType, AveragePrice = 0 },
                new Alcohol { Id = 2, Type = AlcoholType.WhiskyType, AveragePrice = 200 },
                new Alcohol { Id = 3, Type = AlcoholType.WhiskeyType, AveragePrice = 100 },
                new Alcohol { Id = 4, Type = AlcoholType.CognacType, AveragePrice = 150}
            };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}