using Uaine.Objects.Primitives.Values;

public class Treasury : IValue
{
    protected int decimalplaces;
    public int DecimalPlaces => decimalplaces;
    public Treasury(int startingpot, int decimalfigures) : base(startingpot, 0)
    {
        decimalplaces = decimalfigures;
    }
    
    public string ToString()
    {
        string v = Value.ToString();
        return v.Insert(v.Length - decimalplaces, ".");
    }
    public bool hasBalance(int amnt)
    {
        if (Value >= amnt)
            return true;
        return false; //else
    }
    public bool Give(int amnt, ref Treasury TresToBeGiven)
    {
        if(hasBalance(amnt))
        {
            Value -= amnt;
            TresToBeGiven.Value += amnt;
            return true;
        }
        else
        {
            Give(Value, ref TresToBeGiven);
            return false;
        }
    }
}