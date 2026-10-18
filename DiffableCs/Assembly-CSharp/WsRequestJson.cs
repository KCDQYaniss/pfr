//Type is in global namespace

public sealed class WsRequestJson
{
	[JsonProperty("method")]
	public string Method; //Field offset: 0x10
	[JsonProperty("params")]
	public object params; //Field offset: 0x18
	[JsonProperty("id")]
	public string Id; //Field offset: 0x20

	public WsRequestJson() { }

	public virtual string ToString() { }

}

