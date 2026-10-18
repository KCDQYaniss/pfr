namespace UnityEngine.UIElements.Experimental;

public sealed class ValueAnimation`1 : IValueAnimationUpdate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ValueAnimation <.cctor>b__67_0() { }

	}

	private static ObjectPool sObjectPool; //Field offset: 0x0
	private long m_StartTimeMs; //Field offset: 0x0
	private int m_DurationMs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func <easingCurve>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isRunning>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <onAnimationCompleted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <autoRecycle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <recycled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <owner>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <valueUpdated>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func <initialValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func <interpolator>k__BackingField; //Field offset: 0x0
	private T _from; //Field offset: 0x0
	private bool fromValueSet; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private T <to>k__BackingField; //Field offset: 0x0

	public bool autoRecycle
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override int durationMs
	{
		 get { } //Length: 6
		 set { } //Length: 16
	}

	public Func easingCurve
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public T from
	{
		 get { } //Length: 75
		 set { } //Length: 82
	}

	public Func initialValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Func interpolator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override bool isRunning
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Action onAnimationCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private VisualElement owner
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private bool recycled
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public T to
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Action valueUpdated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private static ValueAnimation`1() { }

	public ValueAnimation`1() { }

	private void CheckNotRecycled() { }

	public static ValueAnimation Create(VisualElement e, Func interpolator) { }

	[CompilerGenerated]
	public bool get_autoRecycle() { }

	public override int get_durationMs() { }

	[CompilerGenerated]
	public Func get_easingCurve() { }

	public T get_from() { }

	[CompilerGenerated]
	public Func get_initialValue() { }

	[CompilerGenerated]
	public Func get_interpolator() { }

	[CompilerGenerated]
	public override bool get_isRunning() { }

	[CompilerGenerated]
	public Action get_onAnimationCompleted() { }

	[CompilerGenerated]
	private VisualElement get_owner() { }

	[CompilerGenerated]
	private bool get_recycled() { }

	[CompilerGenerated]
	public T get_to() { }

	[CompilerGenerated]
	public Action get_valueUpdated() { }

	public ValueAnimation KeepAlive() { }

	public override void Recycle() { }

	private void Register() { }

	[CompilerGenerated]
	public void set_autoRecycle(bool value) { }

	public override void set_durationMs(int value) { }

	[CompilerGenerated]
	public void set_easingCurve(Func value) { }

	public void set_from(T value) { }

	[CompilerGenerated]
	public void set_initialValue(Func value) { }

	[CompilerGenerated]
	public void set_interpolator(Func value) { }

	[CompilerGenerated]
	private void set_isRunning(bool value) { }

	[CompilerGenerated]
	public void set_onAnimationCompleted(Action value) { }

	[CompilerGenerated]
	private void set_owner(VisualElement value) { }

	[CompilerGenerated]
	private void set_recycled(bool value) { }

	[CompilerGenerated]
	public void set_to(T value) { }

	[CompilerGenerated]
	public void set_valueUpdated(Action value) { }

	private void SetDefaultValues() { }

	internal void SetOwner(VisualElement e) { }

	public override void Start() { }

	public override void Stop() { }

	private override void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }

	private void Unregister() { }

}

