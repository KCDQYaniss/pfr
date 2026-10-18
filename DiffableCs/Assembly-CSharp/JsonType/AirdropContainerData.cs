namespace JsonType;

public class AirdropContainerData
{
	[JsonProperty("icon")]
	public string Icon; //Field offset: 0x10
	[JsonProperty("container")]
	public FlatItem[] data; //Field offset: 0x18

	public AirdropContainerData() { }

}

