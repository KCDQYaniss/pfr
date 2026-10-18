namespace EFT.UI;

[UsedImplicitly]
public sealed class BattleUIMalfunctionGlow : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public EGlowType glowType; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <ShowGlow>b__0(GlowParams t) { }

	}

	[CompilerGenerated]
	private struct <ProcessGlow>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BattleUIMalfunctionGlow <>4__this; //Field offset: 0x20
		public Sprite sprite; //Field offset: 0x28
		public AnimationCurve curve; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private double <startTime>5__2; //Field offset: 0x40
		private double <endTime>5__3; //Field offset: 0x48
		private YieldAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EGlowType
	{
		Examined = 0,
		Repaired = 1,
		TypeExamined = 2,
	}

	internal struct GlowParams
	{
		public EGlowType Type; //Field offset: 0x0
		public Sprite Glow; //Field offset: 0x8
		public AnimationCurve Curve; //Field offset: 0x10

	}

	private const float GLOW_THRESHOLD = 2; //Field offset: 0x0
	[SerializeField]
	private Image _glow; //Field offset: 0x70
	[SerializeField]
	private GlowParams[] _glows; //Field offset: 0x78
	private float _timeSinceFirstGlowAttempt; //Field offset: 0x80
	private int _showGlowAttempts; //Field offset: 0x84
	private CancellationTokenSource _cts; //Field offset: 0x88
	private float _alphaMultiplier; //Field offset: 0x90

	public BattleUIMalfunctionGlow() { }

	[AsyncStateMachine(typeof(<ProcessGlow>d__11))]
	private Task ProcessGlow(Sprite sprite, AnimationCurve curve, CancellationToken cancellationToken) { }

	public bool ShowGlow(EGlowType glowType, bool force = false, float alphaMultiplier = 1) { }

	[UsedImplicitly]
	private void Start() { }

}

