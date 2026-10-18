namespace EFT.UI.Insurance;

public sealed class InsuranceWindow : Window, IAddHandler, IItemRelatedView, IRemoveHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_1; //Field offset: 0x8
		public static Func <>9__19_2; //Field offset: 0x10
		public static Func <>9__25_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <get_OverallPrice>b__19_1(InsurePrice x) { }

		internal int <get_OverallPrice>b__19_2(InsurePrice x) { }

		internal string <UpdateInfoWindowParameters>b__25_0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public InsuranceWindow <>4__this; //Field offset: 0x10
		public ItemContext itemContext; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <Show>b__0() { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_1
	{
		public Mastering mastered; //Field offset: 0x10
		public <>c__DisplayClass21_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass21_1() { }

		internal float <Show>b__3() { }

	}

	[SerializeField]
	private TextMeshProUGUI _masteringLabel; //Field offset: 0xB8
	[SerializeField]
	private InsurerParametersPanel _insurerParameters; //Field offset: 0xC0
	[SerializeField]
	private ItemInfoWindowLabels _itemLabels; //Field offset: 0xC8
	[SerializeField]
	private CameraImage _cameraImage; //Field offset: 0xD0
	[SerializeField]
	private DefaultUIButton _insureButton; //Field offset: 0xD8
	[SerializeField]
	private GameObject _loader; //Field offset: 0xE0
	private WeaponPreview _weaponPreview; //Field offset: 0xE8
	private Item _item; //Field offset: 0xF0
	private bool _unableToInsure; //Field offset: 0xF8
	private IItemOwner _itemOwner; //Field offset: 0x100
	private HandbookNode _handbookNode; //Field offset: 0x108
	private WeaponPreviewPool _weaponPreviewPool; //Field offset: 0x110
	private InsuranceCompany _insurance; //Field offset: 0x118
	private MessageWindow _messageWindow; //Field offset: 0x120

	private bool Examined
	{
		private get { } //Length: 43
	}

	private List InsuredItemWithChildren
	{
		private get { } //Length: 668
	}

	private PriceData OverallPrice
	{
		private get { } //Length: 941
	}

	public InsuranceWindow() { }

	[CompilerGenerated]
	private bool <get_InsuredItemWithChildren>b__15_0(InsuredItem x) { }

	[CompilerGenerated]
	private InsurePrice <get_OverallPrice>b__19_0(InsuredItem x) { }

	[CompilerGenerated]
	private void <InsureItem>b__26_0(IResult result) { }

	[CompilerGenerated]
	private void <UpdateInsurancePrice>b__23_0(InsuredItem[] arg) { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void CloseItemViewIfEquals(Item item) { }

	private override void EFT.IAddHandler.OnItemAdded(AddItemEventArgs eventArgs) { }

	private override void EFT.IRemoveHandler.OnItemRemoved(RemoveItemEventArgs eventArgs) { }

	private bool get_Examined() { }

	private List get_InsuredItemWithChildren() { }

	private PriceData get_OverallPrice() { }

	private void InsureItem() { }

	public WindowContext Show(ItemContext itemContext, Inventory inventory, InsuranceCompany insuranceCompany, MessageWindow messageWindow, SkillManager skills, WeaponPreviewPool weaponPreviewPool) { }

	private void UpdateInfoWindowParameters() { }

	private void UpdateInsurancePrice() { }

	private void UpdatePrice(PriceData priceData) { }

	private void UpdateStashCounters(EventArgs _) { }

}

