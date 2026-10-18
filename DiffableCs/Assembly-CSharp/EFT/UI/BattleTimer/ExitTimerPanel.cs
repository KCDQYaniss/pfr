namespace EFT.UI.BattleTimer;

public class ExitTimerPanel : TimerPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__46_0; //Field offset: 0x8
		public static Func <>9__46_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateVisitedStatus>b__46_0(ExfiltrationRequirement rq) { }

		internal bool <UpdateVisitedStatus>b__46_1(ExfiltrationRequirement r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal bool <GetTotalDiscount>b__0(IPlayer x) { }

	}

	[CompilerGenerated]
	private sealed class <Co_ChangeColor>d__56 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ExitTimerPanel <>4__this; //Field offset: 0x20
		public Color to; //Field offset: 0x28
		private float <t>5__2; //Field offset: 0x38

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
		public <Co_ChangeColor>d__56(int <>1__state) { }

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

	internal enum EVisitedStatus
	{
		NotVisited = 0,
		Visited = 1,
		Locked = 2,
		BufferZone = 3,
	}

	private const string BUFFER_ZONE_TIMER_LOCALE = "Buffer_zone_timer"; //Field offset: 0x0
	private const int BUFFER_ZONE_WARNING_TIME = 10; //Field offset: 0x0
	[SerializeField]
	protected GameObject _itemsObject; //Field offset: 0xA8
	[SerializeField]
	private CustomTextMeshProUGUI _itemsToBringLabel; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _pointStatusLabel; //Field offset: 0xB8
	[SerializeField]
	private CustomTextMeshProUGUI _pointName; //Field offset: 0xC0
	[SerializeField]
	private Image _backgroundImage; //Field offset: 0xC8
	[SerializeField]
	private Image _requirementImage; //Field offset: 0xD0
	[SerializeField]
	private Image _timerImage; //Field offset: 0xD8
	[SerializeField]
	private Image _bufferZoneTimerIcon; //Field offset: 0xE0
	[SerializeField]
	private Color _visitedTextColor; //Field offset: 0xE8
	[SerializeField]
	private Color _notVisitedTextColor; //Field offset: 0xF8
	[SerializeField]
	private Color _lockedTextColor; //Field offset: 0x108
	[SerializeField]
	private Color _secretExitTextColor; //Field offset: 0x118
	[SerializeField]
	private Color _bufferZoneBackgroundColor; //Field offset: 0x128
	[SerializeField]
	private Color _bufferZoneTextColor; //Field offset: 0x138
	[SerializeField]
	private Color _defaultTimerColor; //Field offset: 0x148
	[SerializeField]
	private Color _warningTimerColor; //Field offset: 0x158
	[SerializeField]
	private Color _defaultTimerBackgroundColor; //Field offset: 0x168
	[SerializeField]
	private Color _warningTimerBackgroundColor; //Field offset: 0x178
	[SerializeField]
	private GameObject _discountStats; //Field offset: 0x188
	[SerializeField]
	private TextMeshProUGUI _totalDiscount; //Field offset: 0x190
	[SerializeField]
	private TextMeshProUGUI _fencerRep; //Field offset: 0x198
	private Color _defaultBackgroundColor; //Field offset: 0x1A0
	protected ExfiltrationPoint _point; //Field offset: 0x1B0
	private Coroutine _moveCoroutine; //Field offset: 0x1B8
	private DateTime _startingDateTime; //Field offset: 0x1C0
	private EVisitedStatus _visited; //Field offset: 0x1C8
	private EPlayerSide _side; //Field offset: 0x1CC
	private int _index; //Field offset: 0x1D0
	private string _profileId; //Field offset: 0x1D8
	private int _raidID; //Field offset: 0x1E0
	private bool _isActivateBufferZoneTimer; //Field offset: 0x1E4
	private bool _anotherTimerConditions; //Field offset: 0x1E5
	private int _secondsInBufferZoneLeft; //Field offset: 0x1E8
	private bool _isSecretExitTimer; //Field offset: 0x1EC

	public bool CanBeShown
	{
		 get { } //Length: 66
	}

	public bool IsVisible
	{
		 get { } //Length: 156
	}

	public ExitTimerPanel() { }

	[IteratorStateMachine(typeof(<Co_ChangeColor>d__56))]
	public IEnumerator Co_ChangeColor(Color to) { }

	public void ForceLockedStatus() { }

	public bool get_CanBeShown() { }

	public bool get_IsVisible() { }

	private TimeSpan GetBufferZoneTimerTimeLeft() { }

	protected TimeSpan GetTimerRequirementTime() { }

	private float GetTotalDiscount(string profileId) { }

	private bool HasTimerRequirement() { }

	protected virtual void OnLocaleUpdated() { }

	public void RedrawCurrentVisitedStatus() { }

	private void SetBufferZoneTimer() { }

	public void SetTimerColor(EMainTimerState status) { }

	protected virtual void SetTimerText(TimeSpan timeSpan) { }

	protected override void SetTimerTextActive() { }

	public void SetVisitedStatus(EVisitedStatus visited) { }

	public override void Show(DateTime dateTime, EPlayerSide side, int index, StringBuilder stringBuilder, string profileId, int raidID, ExfiltrationPoint point = null, bool isActiveBufferZoneTimer = false) { }

	protected virtual void UpdateTimer() { }

	public void UpdateVisitedStatus() { }

}

