namespace EFT.NextObservedPlayer;

public sealed class SpectatorBlindnessState
{
	[CompilerGenerated]
	private BurnEyesEntry[] <Burns>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private StunEntry[] <Stuns>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private float <ReceivedTime>k__BackingField; //Field offset: 0x20

	public private BurnEyesEntry[] Burns
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float ReceivedTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private StunEntry[] Stuns
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SpectatorBlindnessState() { }

	[CompilerGenerated]
	public BurnEyesEntry[] get_Burns() { }

	[CompilerGenerated]
	public float get_ReceivedTime() { }

	[CompilerGenerated]
	public StunEntry[] get_Stuns() { }

	[CompilerGenerated]
	private void set_Burns(BurnEyesEntry[] value) { }

	[CompilerGenerated]
	private void set_ReceivedTime(float value) { }

	[CompilerGenerated]
	private void set_Stuns(StunEntry[] value) { }

	public void Update(SpectatorBlindnessCommandMessage command) { }

}

