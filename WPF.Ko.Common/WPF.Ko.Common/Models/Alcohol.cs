namespace WPF.Ko.Common.Models;

public class Alcohol
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private AlcoholType _type = AlcoholType.EmptyAlcoholType;

    public AlcoholType Type
    {
        get { return _type; }
        set { _type = value; }
    }


    public Alcohol()
    {

    }
}