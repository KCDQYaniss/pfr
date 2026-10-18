namespace EFT.UI;

public sealed class AssembleBuildWindow : Window
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public Handbook handbook; //Field offset: 0x10
		public ItemController itemController; //Field offset: 0x18
		public InsuranceCompany insuranceCompany; //Field offset: 0x20

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0(Item item, AssembleModPanel view) { }

	}

	[SerializeField]
	private TextMeshProUGUI _warningTitle; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI _warningDescription; //Field offset: 0xC0
	[SerializeField]
	private AssembleModPanel _modPanel; //Field offset: 0xC8
	[SerializeField]
	private RectTransform _modPanelContainer; //Field offset: 0xD0
	[SerializeField]
	private Toggle _includePartsToggle; //Field offset: 0xD8
	[SerializeField]
	private TextMeshProUGUI _includePartsLabel; //Field offset: 0xE0
	[SerializeField]
	private DefaultUIButton _ignoreButton; //Field offset: 0xE8
	[SerializeField]
	private DefaultUIButton _buyButton; //Field offset: 0xF0
	private readonly BindableList _modList; //Field offset: 0xF8
	private Action _onBuyButtonClicked; //Field offset: 0x100
	private Action _onIgnoreButtonClicked; //Field offset: 0x108
	private bool _countOnlyEquipped; //Field offset: 0x110
	private IReadOnlyCollection _outOfCollectionItems; //Field offset: 0x118
	private IReadOnlyCollection _itemsInBuild; //Field offset: 0x120

	protected virtual bool DragEnabled
	{
		 get { } //Length: 3
	}

	protected virtual bool ShowOnTop
	{
		 get { } //Length: 3
	}

	public AssembleBuildWindow() { }

	[CompilerGenerated]
	private void <Awake>b__18_0() { }

	[CompilerGenerated]
	private void <Awake>b__18_1() { }

	[CompilerGenerated]
	private void <Awake>b__18_2(bool arg) { }

	protected virtual void Awake() { }

	protected virtual bool get_DragEnabled() { }

	protected virtual bool get_ShowOnTop() { }

	public WindowContext Show(Handbook handbook, IReadOnlyCollection outOfCollectionItems, IReadOnlyCollection itemsInBuild, ItemController itemController, InsuranceCompany insuranceCompany, bool needShowIncludeItemsToggle, Action onIgnoreButtonClicked, Action onBuyButtonClicked) { }

	private void UpdateModList(IReadOnlyCollection items) { }

}

