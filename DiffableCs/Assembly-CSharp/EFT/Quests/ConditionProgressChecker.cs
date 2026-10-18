namespace EFT.Quests;

public class ConditionProgressChecker : IDisposable
{
	public readonly Condition Condition; //Field offset: 0x10
	private Func _currentValueGetter; //Field offset: 0x18
	private bool _currentTestResult; //Field offset: 0x20
	private Nullable _currentValue; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnDisconnect; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnConditionChanged; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnReset; //Field offset: 0x48

	public event Action OnConditionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnDisconnect
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnReset
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public double CurrentValue
	{
		 get { } //Length: 96
	}

	private double GetCurrentValue
	{
		private get { } //Length: 137
	}

	public ConditionProgressChecker(Condition condition) { }

	[CompilerGenerated]
	public void add_OnConditionChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnDisconnect(Action value) { }

	[CompilerGenerated]
	public void add_OnReset(Action value) { }

	public void CallConditionChanged() { }

	public void Disconnect() { }

	public override void Dispose() { }

	public double get_CurrentValue() { }

	private double get_GetCurrentValue() { }

	public bool HasGetter() { }

	public bool IsCompleted() { }

	[CompilerGenerated]
	public void remove_OnConditionChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnDisconnect(Action value) { }

	[CompilerGenerated]
	public void remove_OnReset(Action value) { }

	public void Reset() { }

	public void SetCurrentValueGetter(Func getter) { }

	public override bool Test(object testValue) { }

	protected bool Test(double testValue) { }

	public bool Test() { }

	public virtual string ToString() { }

}

