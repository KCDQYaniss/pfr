namespace EFT;

public sealed class GameModeDescriptor
{
	[CompilerGenerated]
	private readonly EGameMode <GameMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsProfileSelected>k__BackingField; //Field offset: 0x14

	[JsonProperty("gameMode")]
	public EGameMode GameMode
	{
		[CompilerGenerated]
		 get { } //Length: 164
	}

	public bool IsPrestigeAvailable
	{
		 get { } //Length: 20
	}

	public bool IsProfileSelected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsPve
	{
		 get { } //Length: 8
	}

	public bool IsPvp
	{
		 get { } //Length: 20
	}

	public bool IsSeasonal
	{
		 get { } //Length: 8
	}

	[JsonConstructor]
	public GameModeDescriptor(EGameMode gameMode) { }

	[CompilerGenerated]
	public EGameMode get_GameMode() { }

	public bool get_IsPrestigeAvailable() { }

	[CompilerGenerated]
	public bool get_IsProfileSelected() { }

	public bool get_IsPve() { }

	public bool get_IsPvp() { }

	public bool get_IsSeasonal() { }

	public static string GetGameModeLabel(EGameMode gameMode) { }

	[CompilerGenerated]
	public void set_IsProfileSelected(bool value) { }

	public bool TryGetGameModeSwitchTarget(out EGameMode targetGameMode) { }

}

