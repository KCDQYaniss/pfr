namespace EFT.Hideout;

public sealed class WorkoutBehaviour : AreaBehaviour, IQteAreaBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8
		public static Func <>9__29_0; //Field offset: 0x10
		public static Func <>9__33_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_RequirementsPassed>b__25_0(Requirement requirement) { }

		internal bool <Process>b__29_0(QteEffect x) { }

		internal bool <TryToBrokeArm>b__33_0(QteEffect x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public int triggerLevel; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <ChooseDumbbells>b__0(PropsData p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public WorkoutBehaviour <>4__this; //Field offset: 0x10
		public PerkManager perks; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal bool <CalculateExperience>b__0(QteEffect effect) { }

	}

	[CompilerGenerated]
	private struct <Process>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WorkoutBehaviour <>4__this; //Field offset: 0x20
		public QuickTimeEvent[] quickTimeEvents; //Field offset: 0x28
		private QTEResult <result>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int MIN_STRENGTH_SKILL_LEVEL = 0; //Field offset: 0x0
	private const int AVERAGE_STRENGTH_SKILL_LEVEL = 1000; //Field offset: 0x0
	private const int MAX_STRENGTH_SKILL_LEVEL = 2500; //Field offset: 0x0
	private const int BLACK_SCREEN_AWAIT_TIME_BEFORE_QTE = 1000; //Field offset: 0x0
	private const int DELAY_AFTER_QTE_FINISH = 2000; //Field offset: 0x0
	private const int BLACK_SCREEN_AWAIT_TIME_AFTER_QTE = 500; //Field offset: 0x0
	private const string WORKOUT_BROKEN_ARM_BLOCKER_MESSAGE = "WorkoutBrokenArmBlockerMessage"; //Field offset: 0x0
	private const string WORKOUT_TIRED_BLOCKER_MESSAGE = "WorkoutTiredBlockerMessage"; //Field offset: 0x0
	private const string ARM_BROKE_MESSAGE = "arm broke"; //Field offset: 0x0
	private HideoutPlayerOwner _playerOwner; //Field offset: 0x68
	private OfflineHealthController _offlineHealthController; //Field offset: 0x70
	private float _energyReduceSuccessAmount; //Field offset: 0x78
	private float _hydrationReduceSuccessAmount; //Field offset: 0x7C
	private float _energyReduceFailAmount; //Field offset: 0x80
	private float _hydrationReduceFailAmount; //Field offset: 0x84
	private QTEController _qteController; //Field offset: 0x88
	private QteHandleData _qteData; //Field offset: 0x90
	private List _propsData; //Field offset: 0x98
	private List _instantiatedProps; //Field offset: 0xA0
	private HideoutRepresentation _hideout; //Field offset: 0xA8

	private bool HasBrokenArm
	{
		private get { } //Length: 176
	}

	private bool RequirementsPassed
	{
		private get { } //Length: 375
	}

	private Vector3 UnseenPosition
	{
		private get { } //Length: 18
	}

	public WorkoutBehaviour() { }

	private void CalculateExperience() { }

	private void ChooseDumbbells() { }

	private void Clear() { }

	private void ExtractQteData(QteData qteData) { }

	private bool get_HasBrokenArm() { }

	private bool get_RequirementsPassed() { }

	private Vector3 get_UnseenPosition() { }

	private void OnSingleQteFinished(bool succeed, QTEResult qteResult) { }

	private void PlayAnimation(bool succeed) { }

	private void PlaySound(string soundBank) { }

	private void Prepare() { }

	[AsyncStateMachine(typeof(<Process>d__29))]
	private Task Process(QuickTimeEvent[] quickTimeEvents) { }

	public override void StartQte(HideoutPlayerOwner owner, QteHandleData qteData) { }

	private void TryToBrokeArm(int coef) { }

}

