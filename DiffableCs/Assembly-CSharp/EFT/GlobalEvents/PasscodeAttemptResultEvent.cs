namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class PasscodeAttemptResultEvent : SyncEventFromServer
{
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <PasscodeId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <TerminalNetId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Successful>k__BackingField; //Field offset: 0x2C

	public private string PasscodeId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool Successful
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int TerminalNetId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PasscodeAttemptResultEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_PasscodeId() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public bool get_Successful() { }

	[CompilerGenerated]
	public int get_TerminalNetId() { }

	public void Invoke(int playerRaidId, string passcodeId, bool successful, int terminalNetId) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_PasscodeId(string value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_Successful(bool value) { }

	[CompilerGenerated]
	private void set_TerminalNetId(int value) { }

}

