namespace JsonType;

public sealed class SeasonChangedEvent
{
	public int Id; //Field offset: 0x10
	[JsonProperty("season")]
	public ESeason Season; //Field offset: 0x14

	public SeasonChangedEvent() { }

}

