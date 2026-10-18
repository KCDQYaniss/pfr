//Type is in global namespace

public sealed class TraderCard : UIElement, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public TraderInfo trader; //Field offset: 0x10
		public TraderCard <>4__this; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public ETraderCardState state; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <ApplyState>b__0(TraderCardState currentState) { }

	}

	internal enum ETraderCardState
	{
		Locked = 0,
		Available = 1,
		Selected = 2,
	}

	private class TraderCardState
	{
		public ETraderCardState State; //Field offset: 0x10
		public TraderCardStateStyle[] SetStyles; //Field offset: 0x18
		public GameObject[] Enable; //Field offset: 0x20
		public GameObject[] Disable; //Field offset: 0x28

		public TraderCardState() { }

	}

	private class TraderCardStateStyle
	{
		public Color Color; //Field offset: 0x10
		public Graphic[] Graphic; //Field offset: 0x20

		public TraderCardStateStyle() { }

	}

	[SerializeField]
	private TraderCardState[] _states; //Field offset: 0x70
	[SerializeField]
	private TraderAvatar _traderAvatar; //Field offset: 0x78
	[SerializeField]
	private LocalizedText _nickName; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _standing; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _timeLeft; //Field offset: 0x90
	[SerializeField]
	private RankPanel _rankPanel; //Field offset: 0x98
	[SerializeField]
	private Image _mouseOver; //Field offset: 0xA0
	[SerializeField]
	private Image _borderOver; //Field offset: 0xA8
	[SerializeField]
	private GameObject _questionMark; //Field offset: 0xB0
	private DateTime _lastTimerUpdate; //Field offset: 0xB8
	private TraderTooltip _tooltip; //Field offset: 0xC0
	private TraderInfo _trader; //Field offset: 0xC8
	private readonly BindableEvent _onClick; //Field offset: 0xD0

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public TraderCard() { }

	[CompilerGenerated]
	private void <Awake>b__18_0(PointerEventData _) { }

	[CompilerGenerated]
	private void <Awake>b__18_1(PointerEventData _) { }

	public void ApplyState(ETraderCardState state) { }

	private void Awake() { }

	private void DebugAvailable() { }

	private void DebugLocked() { }

	private void DebugSelected() { }

	public IBindableEvent get_OnClick() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	public void SetCardState(TraderInfo selectedTraderInfo) { }

	public void Show(TraderInfo trader, QuestController questController, TraderTooltip tooltip, bool traderHasDialogue) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private void UpdateView() { }

}

