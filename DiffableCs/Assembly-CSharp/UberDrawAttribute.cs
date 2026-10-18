//Type is in global namespace

public class UberDrawAttribute : PropertyAttribute
{
	public readonly string Data; //Field offset: 0x18
	public readonly bool WithLable; //Field offset: 0x20
	public readonly int Lines; //Field offset: 0x24

	public UberDrawAttribute(string data, bool withLable = true) { }

}

