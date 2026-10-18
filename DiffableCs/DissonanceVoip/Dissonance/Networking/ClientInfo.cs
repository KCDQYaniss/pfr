namespace Dissonance.Networking;

internal struct ClientInfo
{
	[CompilerGenerated]
	private string <PlayerName>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ushort <PlayerId>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CodecSettings <CodecSettings>k__BackingField; //Field offset: 0xC

	public private CodecSettings CodecSettings
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private ushort PlayerId
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private string PlayerName
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public ClientInfo(string playerName, ushort playerId, CodecSettings codecSettings) { }

	[CompilerGenerated]
	[IsReadOnly]
	public CodecSettings get_CodecSettings() { }

	[CompilerGenerated]
	[IsReadOnly]
	public ushort get_PlayerId() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_PlayerName() { }

	[CompilerGenerated]
	private void set_CodecSettings(CodecSettings value) { }

	[CompilerGenerated]
	private void set_PlayerId(ushort value) { }

	[CompilerGenerated]
	private void set_PlayerName(string value) { }

}

