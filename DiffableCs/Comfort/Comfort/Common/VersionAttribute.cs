namespace Comfort.Common;

public sealed class VersionAttribute : Attribute
{
	public readonly string Id; //Field offset: 0x10

	public VersionAttribute(string id) { }

}

