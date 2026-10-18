namespace ChatShared;

public sealed class ChatRoomState
{
	[JsonProperty("_id")]
	public string Id; //Field offset: 0x10
	public ushort Members; //Field offset: 0x18

	public ChatRoomState() { }

}

