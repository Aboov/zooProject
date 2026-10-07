public sealed class Serlizer
{
    public ISerializefiles SerlizeStretegy { get; set; }
    public Serlizer(ISerializefiles serlizeStretegy)
    {
        this.SerlizeStretegy = serlizeStretegy;
    }

    public string Serlize(ISerializeable[] serlizeable)
    {
        return SerlizeStretegy.serialize(serlizeable);
    }
}