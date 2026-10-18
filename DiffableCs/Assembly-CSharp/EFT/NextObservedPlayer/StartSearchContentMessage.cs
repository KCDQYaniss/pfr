namespace EFT.NextObservedPlayer;

public sealed class StartSearchContentMessage : ICommandMessage, ISerializableMessage, IDisposable
{
	[CompilerGenerated]
	private string <SearchSoundName>k__BackingField; //Field offset: 0x10

	public string SearchSoundName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override CommandMessageType Type
	{
		 get { } //Length: 6
	}

	public StartSearchContentMessage() { }

	public override ICommandMessage CloneCommand() { }

	public static ICommandMessage CreateInstance() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public string get_SearchSoundName() { }

	public override CommandMessageType get_Type() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_SearchSoundName(string value) { }

}

