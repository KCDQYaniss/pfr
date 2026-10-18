//Type is in global namespace

internal class StateSwitcher
{
	private enum EState
	{
		Off = 0,
		On = 1,
		SwitchingOff = 3,
		SwitchingOn = 2,
	}

	private AnimationCurve _switchingOn; //Field offset: 0x10
	private AnimationCurve _switchingOff; //Field offset: 0x18
	private float _switchingOnEnd; //Field offset: 0x20
	private float _switchingOffEnd; //Field offset: 0x24
	private float _time; //Field offset: 0x28
	private SortedList _switchingOnList; //Field offset: 0x30
	private SortedList _switchingOffList; //Field offset: 0x38
	private IEnumerator _caseEnumerator; //Field offset: 0x40
	private float _caseTime; //Field offset: 0x48
	private EState _switchState; //Field offset: 0x4C
	public Action OnSwitchComplete; //Field offset: 0x50
	[CompilerGenerated]
	private bool <On>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <InProcess>k__BackingField; //Field offset: 0x59
	[CompilerGenerated]
	private float <Value>k__BackingField; //Field offset: 0x5C

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
		 set { } //Length: 253
	}

	public AnimationCurve SwitchingOn
	{
		 get { } //Length: 5
		 set { } //Length: 253
	}

	public private float Value
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public StateSwitcher() { }

	public void AddCase(float time, Action stateChangedCallback, bool switchingOn) { }

	public void ForceSwitch(bool on) { }

	[CompilerGenerated]
	public bool get_InProcess() { }

	[CompilerGenerated]
	public bool get_On() { }

	public AnimationCurve get_SwitchingOff() { }

	public AnimationCurve get_SwitchingOn() { }

	[CompilerGenerated]
	public float get_Value() { }

	private SortedList GetList(bool on) { }

	public void Process(float deltaTime) { }

	private void ProcessCase() { }

	[CompilerGenerated]
	private void set_InProcess(bool value) { }

	[CompilerGenerated]
	private void set_On(bool value) { }

	public void set_SwitchingOff(AnimationCurve value) { }

	public void set_SwitchingOn(AnimationCurve value) { }

	[CompilerGenerated]
	private void set_Value(float value) { }

	public bool Switch(bool on) { }

}

