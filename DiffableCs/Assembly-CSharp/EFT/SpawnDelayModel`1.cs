namespace EFT;

public abstract class SpawnDelayModel`1 : ISpawnDelayModel
{
	protected readonly string CauseStack; //Field offset: 0x0
	public readonly Action ContinuationCallback; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <Count>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly BotCreationData <Data>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly bool <CanBeRemoved>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly float <CreatedTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private float <LastCheckTime>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ERemoveDelayReason <RemoveReason>k__BackingField; //Field offset: 0x0

	public override bool CanBeRemoved
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override float CreatedTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public override BotCreationData Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override float LastCheckTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override ERemoveDelayReason RemoveReason
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected SpawnDelayModel`1(int count, BotCreationData creationData, Action callback) { }

	[CompilerGenerated]
	public override bool get_CanBeRemoved() { }

	[CompilerGenerated]
	public override int get_Count() { }

	[CompilerGenerated]
	public override float get_CreatedTime() { }

	[CompilerGenerated]
	public override BotCreationData get_Data() { }

	[CompilerGenerated]
	public override float get_LastCheckTime() { }

	[CompilerGenerated]
	public override ERemoveDelayReason get_RemoveReason() { }

	public override void OnDelayFinished() { }

	[CompilerGenerated]
	public override void set_LastCheckTime(float value) { }

	[CompilerGenerated]
	public override void set_RemoveReason(ERemoveDelayReason value) { }

	public virtual string ToString() { }

	public abstract string ZoneName() { }

}

