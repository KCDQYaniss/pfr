namespace EFT.UI.DragAndDrop;

public class GridItemView : ItemView, IAddHandler, IItemRelatedView, IRemoveHandler, IMagazineChangedHandler, ILoadMagazineHandler, IUnloadMagazineHandler, IInventoryMagazineCheckHandler, IRefreshHandler, IDrainHandler, IBindHandler, IUnbindHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__74_0; //Field offset: 0x8
		public static Func <>9__104_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <TryGetBuff>b__74_0(BuffComponent subBuff) { }

		internal Item <UpdateInfo>b__104_0(Slot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass120_0
	{
		public RectTransform customObject; //Field offset: 0x10

		public <>c__DisplayClass120_0() { }

		internal void <AddCustomObjectToInfoPanel>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public GridItemView <>4__this; //Field offset: 0x10
		public Weapon weapon; //Field offset: 0x18
		public SelectableItemContext selectableContext; //Field offset: 0x20
		public FilterPanel filterPanel; //Field offset: 0x28

		public <>c__DisplayClass55_0() { }

		internal void <NewGridItemView>b__0() { }

		internal void <NewGridItemView>b__1() { }

		internal void <NewGridItemView>b__2() { }

		internal void <NewGridItemView>b__3() { }

		internal void <NewGridItemView>b__4() { }

		internal void <NewGridItemView>b__5() { }

		internal void <NewGridItemView>b__6() { }

		internal void <NewGridItemView>b__7() { }

	}

	[CompilerGenerated]
	private sealed class <GetActiveBuffs>d__75 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BuffComponent <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public GridItemView <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30

		private override BuffComponent System.Collections.Generic.IEnumerator<EFT.InventoryLogic.BuffComponent>.Current
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
		public <GetActiveBuffs>d__75(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.BuffComponent>.GetEnumerator() { }

		[DebuggerHidden]
		private override BuffComponent System.Collections.Generic.IEnumerator<EFT.InventoryLogic.BuffComponent>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <ResizeTag>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GridItemView <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum EItemValueFormat
	{
		OneValue = 0,
		TwoValues = 1,
		Other = 2,
	}

	private const float MIN_ALLOWED_TAG_SIZE = 40; //Field offset: 0x0
	private const float TAG_TEXT_SIDE_MARGIN = 12; //Field offset: 0x0
	private static Color ACCEPT_COLOR; //Field offset: 0x0
	protected const int OVERLAP_LENGTH = 6; //Field offset: 0x0
	public const float TOOLTIP_DELAY = 0.6; //Field offset: 0x0
	private static Color MERGE_COLOR; //Field offset: 0x10
	[SerializeField]
	private Image _unsearchedBackground; //Field offset: 0x238
	[SerializeField]
	private Image _secureIcon; //Field offset: 0x240
	[SerializeField]
	private Image _lockedIcon; //Field offset: 0x248
	[SerializeField]
	private Image _togglableIcon; //Field offset: 0x250
	[SerializeField]
	private Image _tagColor; //Field offset: 0x258
	[SerializeField]
	private Image _missingLayout; //Field offset: 0x260
	[SerializeField]
	protected TextMeshProUGUI Caption; //Field offset: 0x268
	[SerializeField]
	private TextMeshProUGUI TagName; //Field offset: 0x270
	[SerializeField]
	private BindPanel _bindPanel; //Field offset: 0x278
	[SerializeField]
	private RectTransform _infoPanel; //Field offset: 0x280
	[SerializeField]
	private GameObject _resizeRectPanelTemplate; //Field offset: 0x288
	[SerializeField]
	private WishlistGridView _wishlistView; //Field offset: 0x290
	[SerializeField]
	private GameObject _pinBackground; //Field offset: 0x298
	[SerializeField]
	private GameObject _lockIcon; //Field offset: 0x2A0
	private RectTransform _resizeRectPanel; //Field offset: 0x2A8
	private FilterPanel _filterPanel; //Field offset: 0x2B0
	private InsuranceCompany _insurance; //Field offset: 0x2B8
	private bool _hasResizeConflict; //Field offset: 0x2C0
	private bool _inRaid; //Field offset: 0x2C1
	private bool _isValueProxyActive; //Field offset: 0x2C2
	private SelectableItemContext _selectableContext; //Field offset: 0x2C8
	private WishlistManager _wishlistManager; //Field offset: 0x2D0
	private string _currentItemValue; //Field offset: 0x2D8

	protected private string CurrentItemValue
	{
		 get { } //Length: 8
		private set { } //Length: 141
	}

	private InsuredItem InsuredItem
	{
		private get { } //Length: 14
	}

	protected virtual bool IsInteractable
	{
		 get { } //Length: 3
	}

	private TextMeshProUGUI ItemInscription
	{
		private get { } //Length: 30
	}

	protected TextMeshProUGUI ItemValue
	{
		 get { } //Length: 30
	}

	protected ItemViewStats ItemViewStats
	{
		 get { } //Length: 30
	}

	protected Image LockedIcon
	{
		 get { } //Length: 8
	}

	protected Image SecureIcon
	{
		 get { } //Length: 8
	}

	protected Image TogglableIcon
	{
		 get { } //Length: 8
	}

	protected override string ValueFormat
	{
		 get { } //Length: 49
	}

	private PointerEventsProxy ValuePointerEventsProxy
	{
		private get { } //Length: 30
	}

	private static GridItemView() { }

	public GridItemView() { }

	public void AddCustomObjectToInfoPanel(RectTransform customObject, Vector2 anchoredPosition) { }

	private bool CanHaveMalfunctions(Item item, out Weapon weapon) { }

	protected void ChangeInsuredStatus(InsuredItem item) { }

	protected void ChangeRepairBuffStatus() { }

	protected override void ChangeSelectedStatus(bool selected) { }

	protected virtual void CheckAcceptHandler(DragItemContext dragItemContext) { }

	private void CheckSlot(ItemAddress location) { }

	public static GridItemView Create(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlistManager) { }

	private void DraggedHandler(bool dragged) { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IBindHandler.OnBindItem(BindItemEventArgs eventArgs) { }

	private override void EFT.IDrainHandler.OnDrain(DrainItemEventArgs eventArgs) { }

	private override void EFT.IInventoryMagazineCheckHandler.OnInventoryMagazineCheck(Magazine magazine, float speed, bool status) { }

	private override void EFT.ILoadMagazineHandler.OnLoadMagazine(LoadMagazineEventArgs eventArgs) { }

	private override void EFT.IMagazineChangedHandler.OnMagazineChange(Magazine magazine) { }

	private override void EFT.IRefreshHandler.OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private override void EFT.IUnbindHandler.OnUnbindItem(UnbindItemEventArgs eventArgs) { }

	private override void EFT.IUnloadMagazineHandler.OnUnloadMagazine(UnloadMagazineEventArgs eventArgs) { }

	private void EnableInsuranceIcons(bool enable) { }

	private void FilterChangedHandler() { }

	protected string get_CurrentItemValue() { }

	private InsuredItem get_InsuredItem() { }

	protected virtual bool get_IsInteractable() { }

	private TextMeshProUGUI get_ItemInscription() { }

	protected TextMeshProUGUI get_ItemValue() { }

	protected ItemViewStats get_ItemViewStats() { }

	protected Image get_LockedIcon() { }

	protected Image get_SecureIcon() { }

	protected Image get_TogglableIcon() { }

	protected override string get_ValueFormat() { }

	private PointerEventsProxy get_ValuePointerEventsProxy() { }

	[IteratorStateMachine(typeof(<GetActiveBuffs>d__75))]
	private IEnumerable GetActiveBuffs() { }

	[CanBeNull]
	protected override string GetErrorText() { }

	private string GetItemName(ItemAddress nextAddress) { }

	private string GetItemName() { }

	protected virtual Action GetQuestTooltipRestore() { }

	protected static string GetStackColor(Item item) { }

	private void HideAcceptHighlight() { }

	protected override void HideTooltip() { }

	public virtual void Init(ResourceTypeInfo resourceType, bool isStub = false) { }

	private void InventoryErrorHandler(InventoryError error) { }

	private bool IsFailedToFeedAmmo(Ammo ammo, IMalfunctionController malfunctionController) { }

	private bool IsFailedToFeedMagazine(Magazine magazine, IMalfunctionController malfunctionController) { }

	private bool IsValueProxyActive() { }

	private string ItemShortName(ItemAddress itemAddress) { }

	public virtual void Kill() { }

	protected GridItemView NewGridItemView(Item item, ItemContext sourceContext, ItemRotation rotation, ItemController itemController, IItemOwner itemOwner, FilterPanel filterPanel, IContainerView container, ItemUiContext itemUiContext, InsuranceCompany insurance, WishlistManager wishlistManger = null) { }

	protected virtual void OnBeingExaminedChanged(bool isBeingExamined) { }

	protected virtual void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	private void OnExamine(ExamineItemEventArgs eventArgs) { }

	private void OnHoverEnd(PointerEventData eventData) { }

	private void OnHoverStart(PointerEventData eventData) { }

	protected override void OnItemAdded(AddItemEventArgs eventArgs) { }

	protected override void OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	protected override void OnRefreshItem(RefreshItemEventArgs eventArgs) { }

	[AsyncStateMachine(typeof(<ResizeTag>d__79))]
	private Task ResizeTag() { }

	private void set_CurrentItemValue(string value) { }

	protected override void SetCountValue() { }

	protected override void SetInscription(string inscription) { }

	protected override void SetInscriptionVisibility(bool visible) { }

	protected override void SetItemBinding(Nullable slotName) { }

	protected override void SetItemValue(EItemValueFormat format, bool display, string color, object arg1, object arg2 = null, string color2 = null) { }

	protected void SetValueVisibility(bool visible) { }

	private void ShowAcceptHighlight(DragItemContext dragItemContext) { }

	protected override void ShowTooltip() { }

	private void ShowTooltipArmorPlate(ArmorPlate armorPlate, ArmorSlot armorSlot) { }

	private bool TryGetBuff(out BuffComponent buff) { }

	private bool UnusableDueToMalfunction(Item item) { }

	public virtual void UpdateInfo() { }

	protected virtual void UpdateInfoVisibility(bool isVisible) { }

	private void UpdateItemName() { }

	protected void UpdateItemValue(string newValue) { }

	protected virtual void UpdateStaticInfo() { }

	private void UpdateTag() { }

	private void UpdateValueText() { }

	public virtual void ValidateWishlistView() { }

	private void ValueProxyPointerEnterHandler() { }

	private void ValueProxyPointerExitHandler() { }

}

