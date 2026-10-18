namespace EFT.Communications;

public sealed class UnparsedNotification
{
	[JsonProperty("type")]
	public ENotificationType Type; //Field offset: 0x10
	[JsonProperty("eventId")]
	public string EventId; //Field offset: 0x18

	public UnparsedNotification() { }

}

