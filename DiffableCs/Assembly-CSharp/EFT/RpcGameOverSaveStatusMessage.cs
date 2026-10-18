namespace EFT;

public sealed class RpcGameOverSaveStatusMessage : ISerializableMessage
{
	[CompilerGenerated]
	private int <ErrorCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private AggressorStats <AggressorStats>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <HasAggressor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private VictimStats[] <Victims>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <Experience>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <GameEditionExpMultiplier>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private string <GameEditionExpMultiplierName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <ReferralExpMultiplier>k__BackingField; //Field offset: 0x40

	public AggressorStats AggressorStats
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public int ErrorCode
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int Experience
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int GameEditionExpMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string GameEditionExpMultiplierName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool HasAggressor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int ReferralExpMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public VictimStats[] Victims
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcGameOverSaveStatusMessage(int errorCode, AggressorStats aggressorStats, VictimStats[] victims, int experience, int gameEditionExpMultiplier, string gameEditionExpMultiplierName, int referralExpMultiplier) { }

	public RpcGameOverSaveStatusMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public AggressorStats get_AggressorStats() { }

	[CompilerGenerated]
	public int get_ErrorCode() { }

	[CompilerGenerated]
	public int get_Experience() { }

	[CompilerGenerated]
	public int get_GameEditionExpMultiplier() { }

	[CompilerGenerated]
	public string get_GameEditionExpMultiplierName() { }

	[CompilerGenerated]
	public bool get_HasAggressor() { }

	[CompilerGenerated]
	public int get_ReferralExpMultiplier() { }

	[CompilerGenerated]
	public VictimStats[] get_Victims() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_AggressorStats(AggressorStats value) { }

	[CompilerGenerated]
	public void set_ErrorCode(int value) { }

	[CompilerGenerated]
	public void set_Experience(int value) { }

	[CompilerGenerated]
	public void set_GameEditionExpMultiplier(int value) { }

	[CompilerGenerated]
	public void set_GameEditionExpMultiplierName(string value) { }

	[CompilerGenerated]
	public void set_HasAggressor(bool value) { }

	[CompilerGenerated]
	public void set_ReferralExpMultiplier(int value) { }

	[CompilerGenerated]
	public void set_Victims(VictimStats[] value) { }

}

