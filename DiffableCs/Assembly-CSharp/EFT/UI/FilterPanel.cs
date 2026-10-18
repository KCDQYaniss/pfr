namespace EFT.UI;

public class FilterPanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Type itemType; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <FilterItemByType>b__0(Type x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public FilterRule filterRule; //Field offset: 0x10
		public FilterPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal void <Awake>b__0(PointerEventData arg) { }

	}

	private enum EFilterItemType
	{
		None = 0,
		All = 1,
		Ammo = 2,
		Barter = 3,
		Container = 4,
		Food = 5,
		Goggles = 6,
		Rig = 7,
		Armor = 8,
		Grenade = 9,
		Info = 10,
		Keys = 11,
		Knife = 12,
		Magazine = 13,
		Meds = 14,
		Mod = 15,
		Special = 16,
		Weapon = 17,
		FoundInRaid = 18,
	}

	private class FilterRule
	{
		[CompilerGenerated]
		private readonly EFilterItemType <Type>k__BackingField; //Field offset: 0x10

		public EFilterItemType Type
		{
			[CompilerGenerated]
			 get { } //Length: 164
		}

		public FilterRule(EFilterItemType filterType) { }

		public override bool Check(Item item) { }

		[CompilerGenerated]
		public EFilterItemType get_Type() { }

	}

	private sealed class FilterTabController : SimpleTabController
	{
		private readonly FilterRule _rule; //Field offset: 0x10
		private readonly FilterPanel _panel; //Field offset: 0x18

		public FilterTabController(FilterPanel panel, FilterRule rule) { }

		public virtual void Show() { }

	}

	private sealed class SpawnedInSessionFilterRule : FilterRule
	{

		public SpawnedInSessionFilterRule(EFilterItemType type) { }

		public virtual bool Check(Item item) { }

	}

	private sealed class TypeRelatedFilterRule : FilterRule
	{
		private readonly Type[] _types; //Field offset: 0x18

		public TypeRelatedFilterRule(EFilterItemType filterType, Type[] types) { }

		public virtual bool Check(Item item) { }

	}

	private static readonly FilterRule[] _filterRules; //Field offset: 0x0
	[CompilerGenerated]
	private Action CurrentFilterChanged; //Field offset: 0x70
	[SerializeField]
	protected FilterTab[] _filterTabs; //Field offset: 0x78
	public bool RememberChoice; //Field offset: 0x80
	protected SimpleTooltip _tooltip; //Field offset: 0x88
	protected TabGroup _tabs; //Field offset: 0x90
	private readonly Dictionary _filterTabTypes; //Field offset: 0x98
	private readonly HashSet _items; //Field offset: 0xA0
	[CompilerGenerated]
	private FilterRule <CurrentFilter>k__BackingField; //Field offset: 0xA8
	private readonly Dictionary _registeredItems; //Field offset: 0xB0

	public event Action CurrentFilterChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	private FilterRule CurrentFilter
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static FilterPanel() { }

	public FilterPanel() { }

	[CompilerGenerated]
	private void <Awake>b__21_1(PointerEventData arg) { }

	[CompilerGenerated]
	private bool <GetFilteredItems>b__29_0(Item item) { }

	[CompilerGenerated]
	public void add_CurrentFilterChanged(Action value) { }

	protected override void Awake() { }

	private void ClearAll() { }

	public override void ClearChoice() { }

	public void ClearItems() { }

	public virtual void Close() { }

	protected void FilterChanged() { }

	private static bool FilterItemByType(Item item, Type[] types) { }

	[CompilerGenerated]
	private FilterRule get_CurrentFilter() { }

	public override IEnumerable GetFilteredItems(IEnumerable allItems) { }

	public override bool IsFilteredSingleItem(Item item) { }

	public override void PreInit(Assortment assortment, IEnumerable items) { }

	public override void RegisterItem(Item item) { }

	[CompilerGenerated]
	public void remove_CurrentFilterChanged(Action value) { }

	[CompilerGenerated]
	private void set_CurrentFilter(FilterRule value) { }

	private void SetFilter(FilterRule filter) { }

	public override void Show() { }

	public override void UnregisterItem(Item item) { }

}

