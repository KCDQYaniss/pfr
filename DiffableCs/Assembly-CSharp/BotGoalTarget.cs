//Type is in global namespace

public class BotGoalTarget : BotData
{
	private ZeroGoalTarget _zeroGoal; //Field offset: 0x18
	private PlaceForCheck _goalTarget; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnGoalTargetChange; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnZeroGoalSetted; //Field offset: 0x30

	public event Action OnGoalTargetChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnZeroGoalSetted
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public double CreatedTime
	{
		 get { } //Length: 31
	}

	public int EnvironmentId
	{
		 get { } //Length: 18
	}

	public PlaceForCheck GoalTarget
	{
		 get { } //Length: 5
		 set { } //Length: 410
	}

	public bool IsDanger
	{
		 get { } //Length: 31
	}

	public Nullable Position
	{
		 get { } //Length: 173
	}

	public PlaceForCheckType Type
	{
		 get { } //Length: 27
	}

	public BotGoalTarget(BotOwner owner) { }

	[CompilerGenerated]
	public void add_OnGoalTargetChange(Action value) { }

	[CompilerGenerated]
	public void add_OnZeroGoalSetted(Action value) { }

	public bool CanCheckBody() { }

	public void Clear() { }

	public double get_CreatedTime() { }

	public int get_EnvironmentId() { }

	public PlaceForCheck get_GoalTarget() { }

	public bool get_IsDanger() { }

	public Nullable get_Position() { }

	public PlaceForCheckType get_Type() { }

	public bool HaveMainTarget() { }

	public bool HavePlaceTarget() { }

	public bool HaveZeroTarget() { }

	public void PointLookComplete(int lookingIndex) { }

	[CompilerGenerated]
	public void remove_OnGoalTargetChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnZeroGoalSetted(Action value) { }

	public void set_GoalTarget(PlaceForCheck value) { }

	public void SetTarget(PlaceForCheck place) { }

	private void SetTargetsToZero() { }

	public void SetZeroGoal() { }

}

