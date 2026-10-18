namespace JsonType;

public class AirdropEventResponse
{
	public int Id; //Field offset: 0x10
	[JsonProperty("timestamp")]
	public long LastButtonClickTime; //Field offset: 0x18

	public AirdropEventResponse() { }

}

