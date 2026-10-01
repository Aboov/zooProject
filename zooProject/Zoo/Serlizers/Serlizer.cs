public sealed class Serlizer
{
    public ISerlizeStretegy SerlizeStretegy { get; set; }
    public Serlizer(ISerlizeStretegy serlizeStretegy)
    {
        this.SerlizeStretegy = serlizeStretegy;
    }

    public string Serlize(ISerializeable[] serlizeable)
    {
        return SerlizeStretegy.serialize(serlizeable);
    }
}