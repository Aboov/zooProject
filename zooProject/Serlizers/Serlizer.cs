public sealed class Serlizer
{
    serlizeStretegy SerlizeStretegy;
    public Serlizer(serlizeStretegy serlizeStretegy)
    {
        this.SerlizeStretegy = serlizeStretegy;
    }
    public string SerlizeDictionary(ISerializeable[] serlizeable)
    {
        return SerlizeStretegy.serialize(serlizeable);
    }
}