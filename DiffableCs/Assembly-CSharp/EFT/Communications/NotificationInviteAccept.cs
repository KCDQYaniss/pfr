namespace EFT.Communications;

public sealed class NotificationInviteAccept : Notification
{
	[JsonProperty("aid")]
	public string AccountId; //Field offset: 0x30
	[JsonProperty("_id")]
	public string PlayerId; //Field offset: 0x38
	[JsonProperty("Info")]
	public PlayerInfo Info; //Field offset: 0x40
	[JsonProperty("IsReady")]
	public bool IsReady; //Field offset: 0x48
	[CanBeNull]
	[JsonProperty("PlayerVisualRepresentation")]
	public PlayerVisualRepresentationDescriptor PlayerVisualRepresentation; //Field offset: 0x50

	public virtual string Description
	{
		 get { } //Length: 246
	}

	public NotificationInviteAccept() { }

	public virtual string get_Description() { }

}

