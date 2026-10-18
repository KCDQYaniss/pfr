namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class PasscodeAttemptEvent : SyncEventFromClient
{
	[CompilerGenerated]
	private string <PasscodeId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Input>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <TerminalNetId>k__BackingField; //Field offset: 0x30

	public private string Input
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string PasscodeId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int TerminalNetId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PasscodeAttemptEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	[CompilerGenerated]
	public string get_Input() { }

	[CompilerGenerated]
	public string get_PasscodeId() { }

	[CompilerGenerated]
	public int get_TerminalNetId() { }

	public void Invoke(string passcodeId, int terminalNetId, string input) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

	[CompilerGenerated]
	private void set_Input(string value) { }

	[CompilerGenerated]
	private void set_PasscodeId(string value) { }

	[CompilerGenerated]
	private void set_TerminalNetId(int value) { }

}

