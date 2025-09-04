class NumObj
{
    public int Number;
    public int Occurances;
}

class HeightObj
{
    public int Number;
    public int VisibleCount;
    public int LowCount;

    public int Count
    {
        get => this.LowCount + this.VisibleCount;
    }
}