namespace EFT;

public class CommandLineArgs
{
	private const string SELECTED_GAME_KEY = "game"; //Field offset: 0x0
	private const string SESSION_ID_KEY = "token"; //Field offset: 0x0
	private const string CONFIG_KEY = "config"; //Field offset: 0x0
	public const string EFT_NAME = "eft"; //Field offset: 0x0
	public const string ARENA_NAME = "arena"; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <SessionId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <EncodedLogin>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <ConfigPatch>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <SelectedGame>k__BackingField; //Field offset: 0x28

	public string ConfigPatch
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string EncodedLogin
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string SelectedGame
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string SessionId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CommandLineArgs() { }

	[CompilerGenerated]
	public string get_ConfigPatch() { }

	[CompilerGenerated]
	public string get_EncodedLogin() { }

	[CompilerGenerated]
	public string get_SelectedGame() { }

	[CompilerGenerated]
	public string get_SessionId() { }

}

