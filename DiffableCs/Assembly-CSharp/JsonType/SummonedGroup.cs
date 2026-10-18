namespace JsonType;

public sealed class SummonedGroup
{
	public string GroupId; //Field offset: 0x10
	public string TeamId; //Field offset: 0x18
	public Profile[] Profiles; //Field offset: 0x20

	public SummonedGroup() { }

}

