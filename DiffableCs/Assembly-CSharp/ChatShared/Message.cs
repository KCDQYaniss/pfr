namespace ChatShared;

[Obfuscation(Exclude = True)]
public sealed class Message
{
	public string Id; //Field offset: 0x10
	public string Text; //Field offset: 0x18
	public string SenderId; //Field offset: 0x20

	public Message() { }

}

