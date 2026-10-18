namespace EFT.Hideout;

public class ShrinkingCircleQTE : QTEAction
{
	[CompilerGenerated]
	private struct <Finish>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShrinkingCircleQTE <>4__this; //Field offset: 0x20
		public bool success; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Process>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public ShrinkingCircleQTE <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunAction>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ShrinkingCircleQTE <>4__this; //Field offset: 0x20
		public QuickTimeEvent quickTimeEvent; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float DURATION = 3; //Field offset: 0x0
	[SerializeField]
	private float _speed; //Field offset: 0x20
	[SerializeField]
	private Vector2 _successRange; //Field offset: 0x24
	[SerializeField]
	private float _minScale; //Field offset: 0x2C
	[SerializeField]
	private KeyCode _targetInput; //Field offset: 0x30
	[SerializeField]
	[Space(10)]
	private Image _dynamicCircleImage; //Field offset: 0x38
	[SerializeField]
	private Transform _dynamicCircleInnerBorder; //Field offset: 0x40
	[SerializeField]
	private Transform _dynamicCircleOuterBorder; //Field offset: 0x48
	[SerializeField]
	[Space(10)]
	private Image _staticCircleImage; //Field offset: 0x50
	[SerializeField]
	private Transform _staticCircleInnerBorder; //Field offset: 0x58
	[SerializeField]
	private Transform _staticCircleInnerMask; //Field offset: 0x60
	[SerializeField]
	[Space(10)]
	private Image _staticBackgroundImage; //Field offset: 0x68
	[SerializeField]
	private Sprite _staticBackgroundSpriteBad; //Field offset: 0x70
	[SerializeField]
	private Sprite _staticBackgroundSpriteGood; //Field offset: 0x78
	[SerializeField]
	[Space(10)]
	private Sprite _spriteBad; //Field offset: 0x80
	[SerializeField]
	private Sprite _spriteGood; //Field offset: 0x88
	private double _successStartScale; //Field offset: 0x90
	private double _successEndScale; //Field offset: 0x98
	private bool _isSuccess; //Field offset: 0xA0
	private int _endDelayMilisec; //Field offset: 0xA4
	private Vector3 _initialDynamicInnerScale; //Field offset: 0xA8
	private Vector3 _initialDynamicOuterScale; //Field offset: 0xB4
	private Vector3 _initialStaticInnerScale; //Field offset: 0xC0
	private Vector3 _initialStaticOuterScale; //Field offset: 0xCC
	private Sprite _initialStaticCircleSprite; //Field offset: 0xD8
	private Sprite _initialDynamicCircleSprite; //Field offset: 0xE0
	private Sprite _initialBackgroundSprite; //Field offset: 0xE8
	private bool _initialStateCached; //Field offset: 0xF0

	public ShrinkingCircleQTE() { }

	private void Awake() { }

	private void CacheInitialVisualState() { }

	[AsyncStateMachine(typeof(<Finish>d__35))]
	private Task Finish(bool success, CancellationToken cancellationToken) { }

	private bool IsSuccessInput() { }

	private void KillDynamicTweens() { }

	private void OnDestroy() { }

	private void PrepareAction() { }

	[AsyncStateMachine(typeof(<Process>d__32))]
	private Task Process(CancellationToken cancellationToken) { }

	private void ResetDynamicBordersScale() { }

	[AsyncStateMachine(typeof(<RunAction>d__30))]
	private Task RunAction(QuickTimeEvent quickTimeEvent, CancellationToken cancellationToken) { }

	private void SetSuccessImages(bool success) { }

	public virtual Task StartAction(QuickTimeEvent quickTimeEvent) { }

}

