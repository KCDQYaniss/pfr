namespace ChatShared;

public struct ChatMessageProfileEvent
{
	public string MessageId; //Field offset: 0x0
	public string EventId; //Field offset: 0x8

	public static ChatMessageProfileEvent Create(ProfileChangeEvent profileEvent) { }

}

