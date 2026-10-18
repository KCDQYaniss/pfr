namespace EFT.Hideout;

public sealed class AreaWorldPanel : AreaPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8
		public static Func <>9__18_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <SetInfo>b__18_0(AreaRequirement x) { }

		internal bool <SetInfo>b__18_1(Requirement x) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass21_0
	{
		public Vector3 pos; //Field offset: 0x0
		public Vector2 screenSize; //Field offset: 0xC
		public Vector2 restrictedBorder; //Field offset: 0x14

	}

	[CompilerGenerated]
	private sealed class <SetScale>d__19 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AreaWorldPanel <>4__this; //Field offset: 0x20
		public bool offscreen; //Field offset: 0x28
		private Vector3 <newScale>5__2; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SetScale>d__19(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public const float FADE_DURATION = 0.8; //Field offset: 0x0
	private const float MAX_VISIBILITY_DISTANCE = 10; //Field offset: 0x0
	[SerializeField]
	private CanvasGroup _labelsGroup; //Field offset: 0x100
	[SerializeField]
	private CanvasGroup _panelCanvasGroup; //Field offset: 0x108
	[SerializeField]
	private Vector2 _restrictedBorder; //Field offset: 0x110
	[SerializeField]
	private Vector2 _cameraOffset; //Field offset: 0x118
	private bool _firstPersonMode; //Field offset: 0x120
	private Coroutine _scaleCoroutine; //Field offset: 0x128
	private Vector3 _newPosition; //Field offset: 0x130
	private bool _isActive; //Field offset: 0x13C
	private bool _offscreen; //Field offset: 0x13D
	private float _targetIconAlpha; //Field offset: 0x140
	private float _currentIconAlpha; //Field offset: 0x144

	private bool Offscreen
	{
		private get { } //Length: 8
		private set { } //Length: 492
	}

	public AreaWorldPanel() { }

	[CompilerGenerated]
	internal static bool <SetPosition>g__IntersectsCorner|21_0(ref <>c__DisplayClass21_0 unnamed_param_0) { }

	private void Awake() { }

	private bool get_Offscreen() { }

	protected virtual void Init(AreaData data, Action onSelected) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	private void set_Offscreen(bool value) { }

	protected virtual void SetInfo() { }

	private void SetLabelsVisibility(bool visible) { }

	public void SetPointOfView(bool firstPerson) { }

	public void SetPosition(Vector3 pos) { }

	[IteratorStateMachine(typeof(<SetScale>d__19))]
	private IEnumerator SetScale(bool offscreen) { }

	private void Update() { }

}

