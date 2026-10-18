namespace EFT.UI.DragAndDrop;

public abstract class QuickSlotView : UIInputNode, IContainerView
{
	[CompilerGenerated]
	private sealed class <CrtRebuildLayout>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public QuickSlotView <>4__this; //Field offset: 0x20

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
		public <CrtRebuildLayout>d__28(int <>1__state) { }

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

	public Func TryShowSelectorCommand; //Field offset: 0x80
	[SerializeField]
	protected Image InstallPlace; //Field offset: 0x88
	[SerializeField]
	protected CustomTextMeshProUGUI HotKey; //Field offset: 0x90
	[SerializeField]
	protected CustomTextMeshProUGUI Caption; //Field offset: 0x98
	[SerializeField]
	protected Image Border; //Field offset: 0xA0
	[SerializeField]
	protected Image Background; //Field offset: 0xA8
	[SerializeField]
	private Image _arrow; //Field offset: 0xB0
	protected InventoryController InventoryController; //Field offset: 0xB8
	protected ItemUiContext ItemUiContext; //Field offset: 0xC0
	protected ItemView ItemView; //Field offset: 0xC8
	protected Item Item; //Field offset: 0xD0
	[CompilerGenerated]
	private EBoundItem <BoundIndex>k__BackingField; //Field offset: 0xD8
	private bool _defaultInstallPlaceEnabled; //Field offset: 0xDC
	private bool _isSlotButtonPressed; //Field offset: 0xDD
	private bool _rebuildHotkeyLayout; //Field offset: 0xDE

	protected private EBoundItem BoundIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected QuickSlotView() { }

	public override Task AcceptItem(DragItemContext itemContext, ItemContext targetItemContext) { }

	protected void Awake() { }

	public abstract bool CanAccept(DragItemContext itemContext, ItemContext targetItemContext, out OperationResult operation) { }

	public abstract bool CanDrag(ItemContext itemContext) { }

	[IteratorStateMachine(typeof(<CrtRebuildLayout>d__28))]
	private IEnumerator CrtRebuildLayout() { }

	public override void DisableHighlight() { }

	public override void DragCancelled() { }

	public override void DragStarted() { }

	[CompilerGenerated]
	protected EBoundItem get_BoundIndex() { }

	public override void Hide() { }

	public override void HighlightItemViewPosition(DragItemContext itemContext, ItemContext targetItemContext, bool preview) { }

	protected override void OnDestroy() { }

	private void OnEnable() { }

	private void RefreshMalfunctionForWeapon() { }

	public void RefreshSelection(Item itemInHands) { }

	protected void RemoveItemView() { }

	[CompilerGenerated]
	private void set_BoundIndex(EBoundItem value) { }

	public override void SetBoundIndex(EBoundItem boundIndex) { }

	public void SetHotKeyText(string text) { }

	protected override void SetIconScale() { }

	protected override void SetItem(Item item, InventoryController controller, ItemUiContext itemUiContext) { }

	private void SetNoMalfViewForWeapon() { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public Vector2 ShowArrow(bool show) { }

	protected void ShowInfoPanel(Item item) { }

	public void ShowQuickdrawGlow(bool show, float duration) { }

	public void SwitchVisualSelection(bool selected) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

