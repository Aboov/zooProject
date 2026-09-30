public sealed class Serlizer
{
    ISerlizeStretegy SerlizeStretegy;
    public Serlizer(ISerlizeStretegy serlizeStretegy)
    {
        this.SerlizeStretegy = serlizeStretegy;
    }
    public string Serlize(ISerializeable[] serlizeable)
    {
        return SerlizeStretegy.serialize(serlizeable);
    }
}