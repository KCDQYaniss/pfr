namespace EFT;

public sealed class CmdPlayerEffectsPauseMessage : ISerializableMessage
{
	[CompilerGenerated]
	private string <PlayerProfileID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsPaused>k__BackingField; //Field offset: 0x18

	public private bool IsPaused
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private string PlayerProfileID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public CmdPlayerEffectsPauseMessage() { }

	public CmdPlayerEffectsPauseMessage(string playerProfileID, bool isPaused) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public bool get_IsPaused() { }

	[CompilerGenerated]
	public string get_PlayerProfileID() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	private void set_IsPaused(bool value) { }

	[CompilerGenerated]
	private void set_PlayerProfileID(string value) { }

}

