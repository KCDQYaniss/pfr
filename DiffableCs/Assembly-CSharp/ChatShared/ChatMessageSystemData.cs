namespace ChatShared;

public class ChatMessageSystemData
{
	public string date; //Field offset: 0x10
	public string time; //Field offset: 0x18
	public string location; //Field offset: 0x20
	public string buyerNickname; //Field offset: 0x28
	public string soldItem; //Field offset: 0x30
	public int itemCount; //Field offset: 0x38

	public ChatMessageSystemData() { }

}

