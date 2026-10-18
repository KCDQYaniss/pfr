namespace UI.Hideout;

public class HideoutCustomizationCell : Tab
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__34_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateFilledSlots>b__34_0(Slot s) { }

	}

	[CompilerGenerated]
	private struct <Deselect>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutCustomizationCell <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	[Space(10)]
	private Image _imageIdle; //Field offset: 0x90
	[SerializeField]
	private Image _imageSelected; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _name; //Field offset: 0xA0
	[SerializeField]
	[Space(10)]
	private Image _lockedImage; //Field offset: 0xA8
	[SerializeField]
	private Image _lockedBorderImage; //Field offset: 0xB0
	[SerializeField]
	[Space(10)]
	private GameObject _cellNumberObject; //Field offset: 0xB8
	[SerializeField]
	private Image _cellNumberImage; //Field offset: 0xC0
	[SerializeField]
	private Sprite _cellNumberIdleSprite; //Field offset: 0xC8
	[SerializeField]
	private Sprite _cellNumberSelectedSprite; //Field offset: 0xD0
	[SerializeField]
	private TMP_Text _cellNumberText; //Field offset: 0xD8
	[SerializeField]
	[Space(10)]
	private TMP_Text _slotsNumberText; //Field offset: 0xE0
	private TaskConditionsTooltip _tooltip; //Field offset: 0xE8
	private bool _isShaded; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <IsLocked>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private Dictionary <OfferSlotAssociations>k__BackingField; //Field offset: 0xF8

	public private bool IsLocked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Dictionary OfferSlotAssociations
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutCustomizationCell() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	public void Close() { }

	[AsyncStateMachine(typeof(<Deselect>d__27))]
	public virtual Task Deselect() { }

	[CompilerGenerated]
	public bool get_IsLocked() { }

	[CompilerGenerated]
	public Dictionary get_OfferSlotAssociations() { }

	public virtual void HandlePointerClick(bool isSelectedNow) { }

	public virtual void Init(ITabController controller) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	private void OnSlotItemChanged(Item _) { }

	public virtual void Select(bool sendCallback = true, bool uiOnly = false) { }

	[CompilerGenerated]
	private void set_IsLocked(bool value) { }

	[CompilerGenerated]
	private void set_OfferSlotAssociations(Dictionary value) { }

	public void SetLocked(bool isLocked) { }

	public void SetShaded(bool shaded) { }

	public void Shade(bool shade) { }

	public void Show(Dictionary offerSlotAssociations, Sprite sprite = null, string cellName = null, bool isLocked = false, Nullable cellNumber = null) { }

	private void SubscribeOnSlots() { }

	private void UnsubscribeOnSlots() { }

	private void UpdateFilledSlots() { }

}

