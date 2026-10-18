namespace EFT.Interactive;

public sealed class GarlandSwitcher : InteractiveAmbianceObject, ILightSwitcher
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public GarlandSwitcher <>4__this; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal void <PlayLinearPattern>g__NextColor|0() { }

	}

	[CompilerGenerated]
	private struct <PerformInteraction>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GarlandSwitcher <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ELightType
	{
		None = 0,
		Green = 1,
		Blue = 2,
		Red = 3,
		Any = 100,
	}

	internal enum EPatternType
	{
		Linear = 0,
		Random = 1,
		OnOff = 2,
	}

	internal sealed class GarlandPattern
	{
		public bool Active; //Field offset: 0x10
		public float Speed; //Field offset: 0x14

		public GarlandPattern() { }

	}

	private sealed class Timer
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public Action callback; //Field offset: 0x10

			public <>c__DisplayClass1_0() { }

			internal void <Run>b__0() { }

		}

		[CompilerGenerated]
		private struct <Run>d__3 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public Timer <>4__this; //Field offset: 0x20
			public float time; //Field offset: 0x28
			private Action <callback>5__2; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private Action _callback; //Field offset: 0x10

		public Timer() { }

		public void Reset() { }

		public void Run(float time, Action callback) { }

		[AsyncStateMachine(typeof(<Run>d__3))]
		private Task Run(float time) { }

	}

	[SerializeField]
	private Dictionary _lights; //Field offset: 0x88
	[SerializeField]
	private Dictionary _materialIndexes; //Field offset: 0x90
	[SerializeField]
	private GameObject _garland; //Field offset: 0x98
	[SerializeField]
	private List _order; //Field offset: 0xA0
	public float Intensity; //Field offset: 0xA8
	public float EmissionPower; //Field offset: 0xAC
	private Dictionary _materials; //Field offset: 0xB0
	private bool _enabled; //Field offset: 0xB8
	private float _speed; //Field offset: 0xBC
	private EPatternType _currentPattern; //Field offset: 0xC0
	private EState _ambianceState; //Field offset: 0xC4
	private Timer _timer; //Field offset: 0xC8

	public override bool Enabled
	{
		 get { } //Length: 68
		 set { } //Length: 130
	}

	public GarlandSwitcher() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	public override bool get_Enabled() { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__19))]
	public virtual Task PerformInteraction(ELightStatus status) { }

	private void PlayLinearPattern() { }

	public override void set_Enabled(bool value) { }

	private void SetPattern(EPatternType pattern, float speed) { }

	public override void Switch(EState switchTo) { }

	private void SwitchColor(ELightType color) { }

	private void SwitchLight(Light light, bool active) { }

	private void SwitchMaterial(Material material, bool active) { }

	public override void TurnOff() { }

	public override void TurnOn() { }

}

