namespace EFT.UI;

public sealed class CharacteristicsPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__19_1; //Field offset: 0x8
		public static Func <>9__19_2; //Field offset: 0x10
		public static Predicate <>9__19_0; //Field offset: 0x18
		public static Func <>9__19_7; //Field offset: 0x20
		public static Func <>9__19_8; //Field offset: 0x28
		public static Func <>9__19_9; //Field offset: 0x30
		public static Func <>9__19_12; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <InstantiateItemFields>b__19_0(ItemAttribute x) { }

		internal bool <InstantiateItemFields>b__19_1(ItemAttribute x) { }

		internal EItemAttributeDisplayType <InstantiateItemFields>b__19_12() { }

		internal bool <InstantiateItemFields>b__19_2(ItemAttribute x) { }

		internal RepairableComponent <InstantiateItemFields>b__19_7(ArmorComponent x) { }

		internal float <InstantiateItemFields>b__19_8(RepairableComponent x) { }

		internal float <InstantiateItemFields>b__19_9(RepairableComponent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public CharacteristicsPanel <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal float <InstantiateItemFields>b__13() { }

		internal float <InstantiateItemFields>b__14() { }

		internal void <InstantiateItemFields>b__3(ItemAttribute attribute, CharacteristicPanel full) { }

		internal void <InstantiateItemFields>b__4(ItemAttribute attribute, CompactCharacteristicPanel compact) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1`1
	{
		public ItemAttribute attribute; //Field offset: 0x0

		public <>c__DisplayClass19_1`1() { }

		internal bool <InstantiateItemFields>b__6(ItemAttribute attr) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_2
	{
		public float allDurability; //Field offset: 0x10

		public <>c__DisplayClass19_2() { }

		internal float <InstantiateItemFields>b__10() { }

		internal string <InstantiateItemFields>b__11() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public CharacteristicsPanel <>4__this; //Field offset: 0x10
		public List newAttributes; //Field offset: 0x18

		public <>c__DisplayClass22_0() { }

		internal bool <SyncCompareAttributes>b__0(ItemAttribute attribute) { }

		internal bool <SyncCompareAttributes>b__1(ItemAttribute attribute) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public ItemAttribute attribute; //Field offset: 0x10

		public <>c__DisplayClass22_1() { }

		internal bool <SyncCompareAttributes>b__2(ItemAttribute a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_2
	{
		public ItemAttribute attribute; //Field offset: 0x10

		public <>c__DisplayClass22_2() { }

		internal bool <SyncCompareAttributes>b__3(ItemAttribute a) { }

		internal bool <SyncCompareAttributes>b__4(ItemAttribute a) { }

	}

	[SerializeField]
	private GameObject _infoButtonPanel; //Field offset: 0x70
	[SerializeField]
	private GameObject _characteristics; //Field offset: 0x78
	[SerializeField]
	private Button _infoButton; //Field offset: 0x80
	[SerializeField]
	private Button _charPanelButton; //Field offset: 0x88
	[SerializeField]
	private CharacteristicPanel _charPanelTemplate; //Field offset: 0x90
	[SerializeField]
	private CharacteristicPanel _charDurability; //Field offset: 0x98
	[SerializeField]
	private CharacteristicPanel _charWeight; //Field offset: 0xA0
	[SerializeField]
	private CompactCharacteristicPanel _compactCharTemplate; //Field offset: 0xA8
	[SerializeField]
	private Transform _charPanelContainer; //Field offset: 0xB0
	[SerializeField]
	private bool _expanded; //Field offset: 0xB8
	private Item _item; //Field offset: 0xC0
	private Item _compareItem; //Field offset: 0xC8
	private RangedItemAttribute _weightAttribute; //Field offset: 0xD0
	private SimpleTooltip _tooltip; //Field offset: 0xD8
	private ViewList _fullBarAttributeViewers; //Field offset: 0xE0
	private ViewList _compactBarAttributeViewers; //Field offset: 0xE8
	private MarginsRect _positionMargins; //Field offset: 0xF0

	public CharacteristicsPanel() { }

	[CompilerGenerated]
	internal static void <InstantiateItemFields>g__CompareAttributes|19_5(ViewList viewList, List changedList) { }

	private void Awake() { }

	public virtual void Close() { }

	private void InstantiateItemFields(Item item, Item compareItem) { }

	public void OnCompareRequired(Item compareWith, Slot slot) { }

	public void ResetCompare(Slot slot) { }

	private void SetState(bool expanded) { }

	public void Show(Item item, Item compareItem) { }

	private void SwitchState() { }

	private void SyncCompareAttributes() { }

}

