namespace WPF.Ko.Common.Models;

public class AlcoholType
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    private string _code = string.Empty;

    public string Code
    {
        get { return _code; }
        set { _code = value; }
    }


    public AlcoholType()
    {
    }

    public static AlcoholType EmptyAlcoholType => new AlcoholType { Id = 1, Code = "Empty" };
}