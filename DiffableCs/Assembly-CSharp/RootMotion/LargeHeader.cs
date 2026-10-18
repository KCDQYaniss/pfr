namespace RootMotion;

public class LargeHeader : PropertyAttribute
{
	public string name; //Field offset: 0x18
	public string color; //Field offset: 0x20

	public LargeHeader(string name) { }

	public LargeHeader(string name, string color) { }

}

