namespace EFT.UI;

public sealed class InteractionButtonsContainer : UIElement, ISubInteractionsWrapper, IPointerExitHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0`1
	{
		public ContextInteractions contextInteractions; //Field offset: 0x0
		public InteractionButtonsContainer <>4__this; //Field offset: 0x0
		public List prohibitedInteractions; //Field offset: 0x0
		public IReadOnlyDictionary names; //Field offset: 0x0
		public IReadOnlyDictionary icons; //Field offset: 0x0
		public bool autoClose; //Field offset: 0x0

		public <>c__DisplayClass25_0`1() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

		internal void <Show>g__EffectsChangeHandler|0(IHealthEffect effect) { }

		internal void <Show>g__Redraw|4() { }

		internal void <Show>g__RequestRedraw|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public bool autoClose; //Field offset: 0x10
		public InteractionButtonsContainer <>4__this; //Field offset: 0x18
		public Action onButtonClicked; //Field offset: 0x20
		public Action onMouseHover; //Field offset: 0x28

		public <>c__DisplayClass27_0() { }

		internal void <CreateContextButton>b__0() { }

		internal void <CreateContextButton>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0`1
	{
		public InteractionButtonsContainer <>4__this; //Field offset: 0x0
		public SimpleContextMenuButton button; //Field offset: 0x0
		public ContextInteractions contextInteractions; //Field offset: 0x0
		public T interaction; //Field offset: 0x0

		public <>c__DisplayClass29_0`1() { }

		internal void <CreateInternalContextButton>b__1() { }

		internal void <CreateInternalContextButton>g__OnMouseHover|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0`1
	{
		public SimpleContextMenuButton subMenuButton; //Field offset: 0x0
		public InteractionButtonsContainer <>4__this; //Field offset: 0x0

		public <>c__DisplayClass31_0`1() { }

		internal void <SetSubInteractions>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public SimpleContextMenuButton button; //Field offset: 0x10
		public InteractionButtonsContainer <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <BindButton>b__0() { }

	}

	private const string ICONS_PATH = "Characteristics/Icons/"; //Field offset: 0x0
	[CompilerGenerated]
	private Action _onRealRedraw; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnCloseRequired; //Field offset: 0x78
	[SerializeField]
	public SimpleContextMenu SubMenuTemplate; //Field offset: 0x80
	[SerializeField]
	public Transform SubMenuContainer; //Field offset: 0x88
	[SerializeField]
	private SimpleContextMenuButton _buttonTemplate; //Field offset: 0x90
	[SerializeField]
	private RectTransform _buttonsContainer; //Field offset: 0x98
	[SerializeField]
	private GameObject _background; //Field offset: 0xA0
	[SerializeField]
	private SimpleSpecifiedContextButtons _specifiedButtons; //Field offset: 0xA8
	private UIParent _redrawBinder; //Field offset: 0xB0
	private UIParent _subMenuBinder; //Field offset: 0xB8
	private bool _hasBackground; //Field offset: 0xC0
	private SimpleContextMenu _subMenu; //Field offset: 0xC8
	private SimpleContextMenuButton _subMenuButton; //Field offset: 0xD0
	private readonly Dictionary _buttonPools; //Field offset: 0xD8
	private readonly Dictionary _buttonInstancePools; //Field offset: 0xE0
	private bool _hasIcons; //Field offset: 0xE8
	private bool _redrawRequired; //Field offset: 0xE9

	private event Action _onRealRedraw
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public event Action OnCloseRequired
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public InteractionButtonsContainer() { }

	[CompilerGenerated]
	private void add__onRealRedraw(Action value) { }

	[CompilerGenerated]
	public void add_OnCloseRequired(Action value) { }

	private void Awake() { }

	private void BindButton(SimpleContextMenuButton button) { }

	private void CloseSubMenu() { }

	private SimpleContextMenuButton CreateContextButton(string key, string caption, SimpleContextMenuButton template, RectTransform container, Sprite sprite, Action onButtonClicked, Action onMouseHover, bool subMenu = false, bool autoClose = true) { }

	private SimpleContextMenuButton CreateContextButton(T key, string caption, Sprite sprite, Action onButtonClicked, Action onMouseHover = null, bool subMenu = false, bool autoClose = true) { }

	private void CreateDynamicContextButton(DynamicContextInteraction interaction) { }

	private void CreateInternalContextButton(T interaction, ContextInteractions contextInteractions, string caption, Sprite sprite, bool autoClose) { }

	public void OnDisable() { }

	public override void OnPointerExit(PointerEventData eventData) { }

	[CompilerGenerated]
	private void remove__onRealRedraw(Action value) { }

	[CompilerGenerated]
	public void remove_OnCloseRequired(Action value) { }

	public override void SetSubInteractions(ContextInteractions contextInteractions) { }

	public void Show(ContextInteractions contextInteractions, IReadOnlyDictionary names = null, List prohibitedInteractions = null, Item item = null, IReadOnlyDictionary icons = null, bool autoClose = true) { }

	private void Update() { }

}

