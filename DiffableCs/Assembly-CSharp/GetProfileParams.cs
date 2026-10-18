//Type is in global namespace

public class GetProfileParams
{
	private readonly WildSpawnType Type; //Field offset: 0x10
	private readonly BotDifficulty BotDifficulty; //Field offset: 0x14
	[CompilerGenerated]
	private readonly Nullable <Side>k__BackingField; //Field offset: 0x18

	public Nullable Side
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public GetProfileParams() { }

	[CompilerGenerated]
	private bool <ChooseProfile>b__5_0(Profile x) { }

	public Profile ChooseProfile(List profiles2Select, bool withDelete) { }

	[CompilerGenerated]
	public Nullable get_Side() { }

	public CountTypeBotWave[] PrepareToLoadBackend(int count) { }

}

