//Type is in global namespace

public sealed class SeasonsController : Seasons, ISeasonsController, IDisposable
{
	[CompilerGenerated]
	private struct <Run>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ESeason season; //Field offset: 0x20
		public bool snowWetRendererDisabled; //Field offset: 0x21
		public SeasonsController <>4__this; //Field offset: 0x28
		public SeasonsSettings seasonsSettings; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private abstract class AbstractState
	{
		[CompilerGenerated]
		private SeasonsController <Controller>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly ESeason <Season>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly ESeasonStatus <Status>k__BackingField; //Field offset: 0x19

		internal SeasonsController Controller
		{
			[CompilerGenerated]
			internal get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected static RainController RainController
		{
			 get { } //Length: 97
		}

		public override ESeason Season
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public override ESeasonStatus Status
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		protected AbstractState(SeasonsController controller, ESeasonStatus status, ESeason season) { }

		public override void Dispose() { }

		[CompilerGenerated]
		internal SeasonsController get_Controller() { }

		protected static RainController get_RainController() { }

		[CompilerGenerated]
		public override ESeason get_Season() { }

		[CompilerGenerated]
		public override ESeasonStatus get_Status() { }

		protected static SeasonsMaterialsFixer GetSeasonsMaterialsFixer() { }

		public override Task HandleReconnect(IWinterEventVisual visual, ESeasonStatus status, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings) { }

		[CompilerGenerated]
		private void set_Controller(SeasonsController value) { }

		protected static void UpdateImpostors() { }

	}

	private interface IState : IDisposable
	{

		public ESeason Season
		{
			 get { } //Length: 0
		}

		public ESeasonStatus Status
		{
			 get { } //Length: 0
		}

		public ESeason get_Season() { }

		public ESeasonStatus get_Status() { }

		public Task HandleReconnect(IWinterEventVisual visual, ESeasonStatus status, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings) { }

		public Task Run() { }

		public void SetupVisual(IWinterEventVisual visual) { }

		public void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateAutumn : AbstractState, IState, IDisposable
	{
		[CompilerGenerated]
		private struct <Run>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			private SeasonsMaterialsFixer <fixer>5__2; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		internal StateAutumn(SeasonsController controller) { }

		[AsyncStateMachine(typeof(<Run>d__1))]
		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateAutumnLate : AbstractState, IState, IDisposable
	{
		[CompilerGenerated]
		private struct <Run>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			private SeasonsMaterialsFixer <fixer>5__2; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		internal StateAutumnLate(SeasonsController controller) { }

		[AsyncStateMachine(typeof(<Run>d__1))]
		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateFactoryDefault : AbstractState, IState, IDisposable
	{

		public StateFactoryDefault(SeasonsController controller, ESeasonStatus status, ESeason season) { }

		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateFactoryWinter : AbstractState, IState, IDisposable
	{

		public StateFactoryWinter(SeasonsController controller) { }

		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateSpring : AbstractState, IState, IDisposable
	{
		[CompilerGenerated]
		private struct <Run>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			private SeasonsMaterialsFixer <fixer>5__2; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		internal StateSpring(SeasonsController controller) { }

		[AsyncStateMachine(typeof(<Run>d__1))]
		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateSpringEarly : AbstractState, IState, IDisposable
	{
		[CompilerGenerated]
		private struct <Run>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public StateSpringEarly <>4__this; //Field offset: 0x20
			private SeasonsMaterialsFixer <fixer>5__2; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private readonly Vector3 _springSnowFactor; //Field offset: 0x20

		internal StateSpringEarly(SeasonsController controller, Vector3 springSnowFactor) { }

		[AsyncStateMachine(typeof(<Run>d__2))]
		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateStorm : AbstractState, IState, IDisposable
	{

		internal StateStorm(SeasonsController controller) { }

		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateStormReconnect : AbstractState, IState, IDisposable
	{

		internal StateStormReconnect(SeasonsController controller) { }

		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateSummer : AbstractState, IState, IDisposable
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			private struct <<HandleReconnect>g__SetState|0>d : IAsyncStateMachine
			{
				public int <>1__state; //Field offset: 0x0
				public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
				public <>c__DisplayClass4_0 <>4__this; //Field offset: 0x20
				public IState state; //Field offset: 0x28
				private TaskAwaiter <>u__1; //Field offset: 0x30

				private override void MoveNext() { }

				[DebuggerHidden]
				private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

			}

			public StateSummer <>4__this; //Field offset: 0x10
			public IWinterEventVisual visual; //Field offset: 0x18

			public <>c__DisplayClass4_0() { }

			[AsyncStateMachine(typeof(<<HandleReconnect>g__SetState|0>d))]
			internal Task <HandleReconnect>g__SetState|0(IState state) { }

		}

		[CompilerGenerated]
		private struct <Run>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			private SeasonsMaterialsFixer <fixer>5__2; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		internal StateSummer(SeasonsController controller) { }

		public virtual Task HandleReconnect(IWinterEventVisual visual, ESeasonStatus status, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings) { }

		[AsyncStateMachine(typeof(<Run>d__1))]
		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateUnknown : AbstractState, IState, IDisposable
	{

		public StateUnknown(SeasonsController controller) { }

		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private sealed class StateWinter : AbstractState, IState, IDisposable
	{
		[CompilerGenerated]
		private struct <Run>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public StateWinter <>4__this; //Field offset: 0x20
			private SeasonsMaterialsFixer <fixer>5__2; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private readonly bool _snowWetRendererDisabled; //Field offset: 0x20

		internal StateWinter(SeasonsController controller, bool snowWetRendererDisabled) { }

		[AsyncStateMachine(typeof(<Run>d__2))]
		public override Task Run() { }

		public override void SetupVisual(IWinterEventVisual visual) { }

		public override void StormStarted(IWinterEventVisual visual) { }

	}

	private IState _state; //Field offset: 0x10
	[CompilerGenerated]
	private Action StatusChangedEvent; //Field offset: 0x18
	private IWinterEventVisual _visual; //Field offset: 0x20
	private Action _stormStartedUnsubscribe; //Field offset: 0x28

	public override event Action SnowLevelOnTerrainChangedEvent
	{
		 add { } //Length: 411
		 remove { } //Length: 411
	}

	public override event Action StatusChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override ESeason Season
	{
		 get { } //Length: 78
	}

	public override float SnowLevelOnTerrain
	{
		 get { } //Length: 149
	}

	public override ESeasonStatus Status
	{
		 get { } //Length: 81
	}

	public SeasonsController() { }

	public override void add_SnowLevelOnTerrainChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void add_StatusChangedEvent(Action value) { }

	private Task CreateState(ESeason season, SeasonsSettings seasonsSettings, bool snowWetRendererDisabled) { }

	public override void Dispose() { }

	public override ESeason get_Season() { }

	public override float get_SnowLevelOnTerrain() { }

	public override ESeasonStatus get_Status() { }

	public override Task HandleReconnect(ESeasonStatus seasonStatus, bool snowWetRendererDisabled, SeasonsSettings seasonsSettings) { }

	public override void Register(IWinterEventVisual winterVisual) { }

	public override void remove_SnowLevelOnTerrainChangedEvent(Action value) { }

	[CompilerGenerated]
	public override void remove_StatusChangedEvent(Action value) { }

	[AsyncStateMachine(typeof(<Run>d__29))]
	public Task Run(ESeason season, SeasonsSettings seasonsSettings, bool snowWetRendererDisabled) { }

	private void StormStartedHandler(StormStartedEvent stormStartedEvent) { }

	public override void Unregister(IWinterEventVisual winterVisual) { }

}

