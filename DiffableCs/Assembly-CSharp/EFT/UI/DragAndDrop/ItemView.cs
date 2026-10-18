namespace EFT.UI.DragAndDrop;

public abstract class ItemView : AssetPoolObject, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IUIView, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__126_1; //Field offset: 0x8
		public static Func <>9__126_2; //Field offset: 0x10
		public static Func <>9__133_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <InitInteractiveBinding>b__133_0(bool filtered, bool dragged, bool added, bool drained, bool removed, bool searched, bool loadAmmo) { }

		internal bool <NewItemView>b__126_1(bool dragged, bool removed) { }

		internal bool <NewItemView>b__126_2(bool added, bool removed, bool examined, bool loaded) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_0
	{
		public float minAlpha; //Field offset: 0x10
		public float maxAlpha; //Field offset: 0x14

		public <>c__DisplayClass117_0() { }

		internal float <get_Transparency>b__0(bool dragDisabled, Error removeError) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public ItemView <>4__this; //Field offset: 0x10
		public IFavoriteContextComponent favoriteContext; //Field offset: 0x18

		public <>c__DisplayClass126_0() { }

		internal void <NewItemView>b__0() { }

		internal void <NewItemView>b__3(bool drained) { }

		internal void <NewItemView>b__4(float transparency) { }

		internal void <NewItemView>b__5(bool isInteractive) { }

		internal void <NewItemView>b__6(Item item1) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass129_0
	{
		public RepairKit repairKit; //Field offset: 0x10

		public <>c__DisplayClass129_0() { }

		internal bool <CanInteract>b__0(RepairableComponent subRepairable) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass172_0
	{
		public Item item; //Field offset: 0x10
		public SlotItemAddress address; //Field offset: 0x18

		public <>c__DisplayClass172_0() { }

		internal bool <GetBindingForItem>b__0(KeyValuePair pair) { }

		internal bool <GetBindingForItem>b__1(KeyValuePair pair) { }

	}

	protected const int HIGHLIGHT_ALPHA = 50; //Field offset: 0x0
	protected const int BACKGROUND_ALPHA = 77; //Field offset: 0x0
	private const float DOUBLE_CLICK_DELAY = 0.3; //Field offset: 0x0
	public static readonly Color DefaultSelectedColor; //Field offset: 0x0
	[SerializeField]
	protected ItemViewAnimation Animator; //Field offset: 0x90
	[SerializeField]
	protected Image MainImage; //Field offset: 0x98
	[SerializeField]
	protected Image ColorPanel; //Field offset: 0xA0
	[SerializeField]
	protected Image _border; //Field offset: 0xA8
	[SerializeField]
	private GameObject _drainLoader; //Field offset: 0xB0
	[SerializeField]
	private GameObject _iconLoader; //Field offset: 0xB8
	[SerializeField]
	protected CanvasGroup CanvasGroup; //Field offset: 0xC0
	[SerializeField]
	protected GameObject InsuredItemBorder; //Field offset: 0xC8
	[SerializeField]
	private float _mainImageAlpha; //Field offset: 0xD0
	[SerializeField]
	private Image _favoriteImage; //Field offset: 0xD8
	[SerializeField]
	private Image _unFavoriteImage; //Field offset: 0xE0
	[SerializeField]
	protected ItemViewBottomPanel BottomPanel; //Field offset: 0xE8
	protected Color SelectedColor; //Field offset: 0xF0
	[CompilerGenerated]
	private readonly BindableState <IsBeingDragged>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private readonly BindableState <IsBeingRemoved>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private readonly BindableState <IsBeingAdded>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private readonly BindableState <IsBeingDrained>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private readonly BindableState <IsFilteredOut>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private readonly BindableState <IsDisabledDrag>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private readonly BindableState <IsBeingSearched>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private readonly BindableState <IsBeingExamined>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private readonly BindableState <IsBeingLoadedMagazine>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private readonly BindableState <IsBeingUnloadedMagazine>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private readonly BindableState <IsBeingLoadedAmmo>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private readonly BindableState <RemoveError>k__BackingField; //Field offset: 0x158
	public IContainerView Container; //Field offset: 0x160
	private bool _isSearched; //Field offset: 0x168
	public bool IsConflicting; //Field offset: 0x169
	protected ItemUiContext ItemUiContext; //Field offset: 0x170
	private IBindable Blinking; //Field offset: 0x178
	private IBindable InfoVisibility; //Field offset: 0x180
	protected IBindable IsInteractive; //Field offset: 0x188
	private bool Highlighted; //Field offset: 0x190
	protected bool HighlightedGlobally; //Field offset: 0x191
	protected bool IsKilled; //Field offset: 0x192
	protected ItemRotation _itemRotation; //Field offset: 0x194
	protected Color OriginalBackgroundColor; //Field offset: 0x198
	protected Color BackgroundColor; //Field offset: 0x1A8
	protected ItemController ItemController; //Field offset: 0x1B8
	protected IItemOwner ItemOwner; //Field offset: 0x1C0
	protected bool IsTeammateDogtag; //Field offset: 0x1C8
	private float _previousMainImageAlpha; //Field offset: 0x1CC
	private RectTransform _rectTransform; //Field offset: 0x1D0
	protected readonly CompositeDisposable CompositeDisposable; //Field offset: 0x1D8
	private ItemIcon _itemIcon; //Field offset: 0x1E0
	private Nullable _iconScale; //Field offset: 0x1E8
	private Action _iconSubscription; //Field offset: 0x1F8
	private PointerEventData _lastKnownMouseEvent; //Field offset: 0x200
	private Nullable _defaultBorderColor; //Field offset: 0x208
	[CompilerGenerated]
	private ItemContext <ItemContext>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private Item <Item>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private DraggedItemView <DraggedItemView>k__BackingField; //Field offset: 0x230

	public bool BeingDragged
	{
		 get { } //Length: 45
	}

	public Color BorderColor
	{
		 set { } //Length: 404
	}

	[CanBeNull]
	protected private DraggedItemView DraggedItemView
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private override GameObject EFT.UI.IUIView.GameObject
	{
		private get { } //Length: 78
	}

	private override Transform EFT.UI.IUIView.Transform
	{
		private get { } //Length: 78
	}

	protected override bool Examined
	{
		 get { } //Length: 50
	}

	protected HoverTrigger HoverTrigger
	{
		 get { } //Length: 30
	}

	public Nullable IconScale
	{
		 get { } //Length: 25
		 set { } //Length: 41
	}

	protected GameObject InsuredIcon
	{
		 get { } //Length: 30
	}

	public BindableState IsBeingAdded
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected BindableState IsBeingDragged
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingDrained
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingExamined
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingLoadedAmmo
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingLoadedMagazine
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingRemoved
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingSearched
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsBeingUnloadedMagazine
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsDisabledDrag
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BindableState IsFilteredOut
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected abstract bool IsInteractable
	{
		 get { } //Length: 0
	}

	public bool IsSearched
	{
		 get { } //Length: 8
		 set { } //Length: 35
	}

	public private Item Item
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private ItemContext ItemContext
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override ItemRotation ItemRotation
	{
		 get { } //Length: 7
		 set { } //Length: 834
	}

	protected ContextInteractions NewContextInteractions
	{
		 get { } //Length: 43
	}

	protected override bool PropagateClicks
	{
		 get { } //Length: 3
	}

	private QuestItemViewPanel QuestsItemViewPanel
	{
		private get { } //Length: 30
	}

	protected RectTransform RectTransform
	{
		 get { } //Length: 462
	}

	public BindableState RemoveError
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected Image RepairBuffIcon
	{
		 get { } //Length: 30
	}

	protected override IBindable Transparency
	{
		 get { } //Length: 536
	}

	private static ItemView() { }

	protected ItemView() { }

	[CompilerGenerated]
	private void <RegisterItemView>b__139_0() { }

	private bool CanDrag(PointerEventData eventData) { }

	protected bool CanInteract(DragItemContext dragItemContext) { }

	private void ChangeFavoriteStatus(Item item, IFavoriteContextComponent favoriteComponent) { }

	protected override void CheckAcceptHandler(DragItemContext dragItemContext) { }

	protected override ItemContext CreateNewItemContext(ItemContext sourceContext) { }

	private void DragStateHandler(bool isBeingDragged) { }

	private override GameObject EFT.UI.IUIView.get_GameObject() { }

	private override Transform EFT.UI.IUIView.get_Transform() { }

	protected bool ExecuteMiddleClick() { }

	public bool get_BeingDragged() { }

	[CompilerGenerated]
	protected DraggedItemView get_DraggedItemView() { }

	protected override bool get_Examined() { }

	protected HoverTrigger get_HoverTrigger() { }

	public Nullable get_IconScale() { }

	protected GameObject get_InsuredIcon() { }

	[CompilerGenerated]
	public BindableState get_IsBeingAdded() { }

	[CompilerGenerated]
	protected BindableState get_IsBeingDragged() { }

	[CompilerGenerated]
	public BindableState get_IsBeingDrained() { }

	[CompilerGenerated]
	public BindableState get_IsBeingExamined() { }

	[CompilerGenerated]
	public BindableState get_IsBeingLoadedAmmo() { }

	[CompilerGenerated]
	public BindableState get_IsBeingLoadedMagazine() { }

	[CompilerGenerated]
	public BindableState get_IsBeingRemoved() { }

	[CompilerGenerated]
	public BindableState get_IsBeingSearched() { }

	[CompilerGenerated]
	public BindableState get_IsBeingUnloadedMagazine() { }

	[CompilerGenerated]
	public BindableState get_IsDisabledDrag() { }

	[CompilerGenerated]
	public BindableState get_IsFilteredOut() { }

	protected abstract bool get_IsInteractable() { }

	public bool get_IsSearched() { }

	[CompilerGenerated]
	public Item get_Item() { }

	[CompilerGenerated]
	public ItemContext get_ItemContext() { }

	public override ItemRotation get_ItemRotation() { }

	protected ContextInteractions get_NewContextInteractions() { }

	protected override bool get_PropagateClicks() { }

	private QuestItemViewPanel get_QuestsItemViewPanel() { }

	protected RectTransform get_RectTransform() { }

	[CompilerGenerated]
	public BindableState get_RemoveError() { }

	protected Image get_RepairBuffIcon() { }

	protected override IBindable get_Transparency() { }

	protected static Nullable GetBindingForItem(ItemController itemController, Item item) { }

	protected override Action GetQuestTooltipRestore() { }

	public void Highlight(bool highlight) { }

	private void IconChangedHandler() { }

	protected private void Init() { }

	protected override void InitInteractiveBinding() { }

	private void IsFilteredOutHandler(bool filterState) { }

	public override void Kill() { }

	protected void NewItemView(Item item, ItemContext sourceItemContext, ItemRotation rotation, ItemController itemController, IContainerView container, IItemOwner itemOwner, ItemUiContext itemUiContext) { }

	protected void OnApplicationFocus(bool hasFocus) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	protected override void OnBeingExaminedChanged(bool isBeingExamined) { }

	protected override void OnClick(InputButton button, Vector2 position, bool doubleClick) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void ProcessItem(DragItemContext dragItemContext, PointerEventData eventData) { }

	protected override void RefreshIcon() { }

	protected override void RegisterItemView() { }

	public void Rotate() { }

	public void set_BorderColor(Color value) { }

	[CompilerGenerated]
	private void set_DraggedItemView(DraggedItemView value) { }

	public void set_IconScale(Nullable value) { }

	protected void set_IsSearched(bool value) { }

	[CompilerGenerated]
	private void set_Item(Item value) { }

	[CompilerGenerated]
	private void set_ItemContext(ItemContext value) { }

	protected override void set_ItemRotation(ItemRotation value) { }

	public void SetBeingExaminedState(ExamineItemEventArgs activeEvent) { }

	protected void SetInventoryCheckMagazineStatus(float time, bool value) { }

	public void SetLoadAmmoStatus(ItemEventArgs activeEvent) { }

	public void SetLoadMagazineStatus(LoadMagazineEventArgs activeEvent) { }

	protected void SetQuestItemViewPanel() { }

	public void SetUnloadMagazineStatus(UnloadMagazineEventArgs activeEvent) { }

	protected void ShowContextMenu(Vector2 position) { }

	private override void System.IDisposable.Dispose() { }

	private void TryStrictCheckMagazineOnFailedDrop(DragItemContext dragItemContext, ItemContext itemUnderCursor, OperationResult possibleOperation) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	protected override void Update() { }

	protected void UpdateColor() { }

	private void UpdateCompoundItemInfo() { }

	private void UpdateDogtagInfo() { }

	public override void UpdateInfo() { }

	protected override void UpdateInfoVisibility(bool isVisible) { }

	public override void UpdateRemoveError(bool ignoreMalfunctions = true) { }

	protected override void UpdateScale() { }

	protected override void UpdateStaticInfo() { }

	public override void ValidateWishlistView() { }

}

