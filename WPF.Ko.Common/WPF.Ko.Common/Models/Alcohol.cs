using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF.Ko.Common.Models;

public class Alcohol : INotifyPropertyChanged
{
    private int _id;
    private decimal _averagePrice;
    private AlcoholType _type = AlcoholType.EmptyAlcoholType;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }


    public AlcoholType Type
    {
        get { return _type; }
        set { _type = value; }
    }


    public decimal AveragePrice
    {
        get { return _averagePrice; }
        set { _averagePrice = value; }
    }


    public Alcohol()
    {

    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}