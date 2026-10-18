//Type is in global namespace

[IsReadOnly]
public struct WsPushNotificationMessage
{
	public readonly string Payload; //Field offset: 0x0
	public readonly string[] Messages; //Field offset: 0x8
	public readonly string Method; //Field offset: 0x10
	public readonly string EventId; //Field offset: 0x18

	public WsPushNotificationMessage(string payload, string[] messages, string method, string eventId) { }

}

