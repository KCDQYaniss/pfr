namespace Assets.Scripts.Utils;

public class StateSwitcher
{
	internal enum State
	{
		off = 0,
		on = 1,
		switchingOff = 3,
		switchingOn = 2,
	}

	[CompilerGenerated]
	private State <SwitchState>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <On>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <InProcess>k__BackingField; //Field offset: 0x15
	[CompilerGenerated]
	private float <Value>k__BackingField; //Field offset: 0x18
	private AnimationCurve _switchingOn; //Field offset: 0x20
	private AnimationCurve _switchingOff; //Field offset: 0x28
	private float _switchingOnEnd; //Field offset: 0x30
	private float _switchingOffEnd; //Field offset: 0x34
	private float t; //Field offset: 0x38
	private SortedList _switchingOnList; //Field offset: 0x40
	private SortedList _switchingOffList; //Field offset: 0x48
	private IEnumerator _caseEnumerator; //Field offset: 0x50
	private float _caseTime; //Field offset: 0x58

	public private bool InProcess
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool On
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AnimationCurve SwitchingOff
	{
		 get { } //Length: 5
		 set { } //Length: 221
	}

	public AnimationCurve SwitchingOn
	{
		 get { } //Length: 5
		 set { } //Length: 221
	}

	public private State SwitchState
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float Value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public StateSwitcher() { }

	public void AddCase(float time, Action Func, bool switchingOn) { }

	public void ForceSwitch(bool on) { }

	[CompilerGenerated]
	public bool get_InProcess() { }

	[CompilerGenerated]
	public bool get_On() { }

	public AnimationCurve get_SwitchingOff() { }

	public AnimationCurve get_SwitchingOn() { }

	[CompilerGenerated]
	public State get_SwitchState() { }

	[CompilerGenerated]
	public float get_Value() { }

	private SortedList getList(bool on) { }

	public void Process(float deltaTime) { }

	private void ProcessCase() { }

	[CompilerGenerated]
	private void set_InProcess(bool value) { }

	[CompilerGenerated]
	private void set_On(bool value) { }

	public void set_SwitchingOff(AnimationCurve value) { }

	public void set_SwitchingOn(AnimationCurve value) { }

	[CompilerGenerated]
	private void set_SwitchState(State value) { }

	[CompilerGenerated]
	private void set_Value(float value) { }

	public bool Switch(bool on) { }

}

