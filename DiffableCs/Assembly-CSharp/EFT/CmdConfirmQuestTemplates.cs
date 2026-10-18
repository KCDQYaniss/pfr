namespace EFT;

public sealed class CmdConfirmQuestTemplates : ISerializableMessage
{
	[CompilerGenerated]
	private string <PlayerProfileID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x18

	public private string Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string PlayerProfileID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CmdConfirmQuestTemplates() { }

	public CmdConfirmQuestTemplates(string profileId, string error) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public string get_PlayerProfileID() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	private void set_PlayerProfileID(string value) { }

}

