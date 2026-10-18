namespace EFT.Communications;

[IsReadOnly]
internal struct NotificationProcessResult
{
	[CompilerGenerated]
	private readonly EProcessError <Error>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <EventId>k__BackingField; //Field offset: 0x8

	public EProcessError Error
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public string EventId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public NotificationProcessResult(EProcessError error, string eventId = null) { }

	[CompilerGenerated]
	public EProcessError get_Error() { }

	[CompilerGenerated]
	public string get_EventId() { }

}

