//Type is in global namespace

public class TimerManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public TimerManager <>4__this; //Field offset: 0x10
		public Timer timer; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <MakeTimer>b__0() { }

		internal void <MakeTimer>b__1() { }

	}

	internal interface ITimer
	{

		public event Action OnTimer
		{
			[CompilerGenerated]
			 add { } //Length: 0
			[CompilerGenerated]
			 remove { } //Length: 0
		}

		public float Duration
		{
			 get { } //Length: 0
		}

		public float EndTime
		{
			 get { } //Length: 0
		}

		public bool IsActive
		{
			 get { } //Length: 0
		}

		public bool IsLoopped
		{
			 get { } //Length: 0
		}

		public float StartTime
		{
			 get { } //Length: 0
		}

		public float TimeLeft
		{
			 get { } //Length: 0
		}

		[CompilerGenerated]
		public void add_OnTimer(Action value) { }

		public float get_Duration() { }

		public float get_EndTime() { }

		public bool get_IsActive() { }

		public bool get_IsLoopped() { }

		public float get_StartTime() { }

		public float get_TimeLeft() { }

		[CompilerGenerated]
		public void remove_OnTimer(Action value) { }

		public void Restart(float endTime) { }

		public void Stop(bool shallFire = false) { }

	}

	private class Timer : ITimer
	{
		private Action onStop; //Field offset: 0x10
		private Action onStart; //Field offset: 0x18
		[CompilerGenerated]
		private Action OnTimer; //Field offset: 0x20
		[CompilerGenerated]
		private float <EndTime>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private float <Duration>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		private bool <IsLoopped>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private bool <IsActive>k__BackingField; //Field offset: 0x31

		public override event Action OnTimer
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public private override float Duration
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override float EndTime
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private override bool IsActive
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private override bool IsLoopped
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public override float StartTime
		{
			 get { } //Length: 11
		}

		public override float TimeLeft
		{
			 get { } //Length: 91
		}

		public Timer() { }

		[CompilerGenerated]
		public override void add_OnTimer(Action value) { }

		public void Fire() { }

		[CompilerGenerated]
		public override float get_Duration() { }

		[CompilerGenerated]
		public override float get_EndTime() { }

		[CompilerGenerated]
		public override bool get_IsActive() { }

		[CompilerGenerated]
		public override bool get_IsLoopped() { }

		public override float get_StartTime() { }

		public override float get_TimeLeft() { }

		public void Init(Action onStop, Action onStart) { }

		[CompilerGenerated]
		public override void remove_OnTimer(Action value) { }

		public override void Restart(float endTime) { }

		[CompilerGenerated]
		private void set_Duration(float value) { }

		[CompilerGenerated]
		private void set_EndTime(float value) { }

		[CompilerGenerated]
		private void set_IsActive(bool value) { }

		[CompilerGenerated]
		private void set_IsLoopped(bool value) { }

		public void Start(float endTime, float duration, bool isLopped = false) { }

		public override void Stop(bool shallFire = false) { }

	}

	private LinkedList timers; //Field offset: 0x10

	public TimerManager() { }

	private void AddTimer(Timer timer) { }

	public ITimer MakeTimer(float endTime, float duration, bool isLopped = false) { }

	public ITimer MakeTimer(TimeSpan duration, bool isLopped = false) { }

	public void StopAllTimers() { }

	public void Update() { }

}

