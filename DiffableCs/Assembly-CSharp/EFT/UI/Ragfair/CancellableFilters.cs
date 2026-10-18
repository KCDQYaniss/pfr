namespace EFT.UI.Ragfair;

[DefaultMember("Item")]
public sealed class CancellableFilters
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__29_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RemoveFilter>b__29_1(CancellableFilter foundFilter) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public EFilterType type; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <get_Item>b__0(CancellableFilter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public EFilterType item; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <RemoveFilter>b__2(CancellableFilter x) { }

	}

	private const int MAX_MAXIMUM_HORIZONTAL_FILTERS_COUNT = 2; //Field offset: 0x0
	[CompilerGenerated]
	private Action ItemAdded; //Field offset: 0x10
	[CompilerGenerated]
	private Action ItemRemoved; //Field offset: 0x18
	private BindableFilterList _lastAssignedFilter; //Field offset: 0x20
	private List _filtersStorage; //Field offset: 0x28
	[CompilerGenerated]
	private readonly BindableFilterList <HorizontalFilters>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly BindableFilterList <VerticalFilters>k__BackingField; //Field offset: 0x38

	public event Action ItemAdded
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action ItemRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public CancellableFilter[] AllFilters
	{
		 get { } //Length: 215
	}

	public int Count
	{
		 get { } //Length: 29
	}

	public BindableFilterList HorizontalFilters
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	[CanBeNull]
	private CancellableFilter Item
	{
		private get { } //Length: 214
	}

	public BindableFilterList VerticalFilters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CancellableFilters() { }

	[CompilerGenerated]
	private CancellableFilter <RemoveFilter>b__29_0(EFilterType item) { }

	[CompilerGenerated]
	public void add_ItemAdded(Action value) { }

	[CompilerGenerated]
	public void add_ItemRemoved(Action value) { }

	public void AddFilter(CancellableFilter filter) { }

	public void Clear() { }

	[CanBeNull]
	public CancellableFilter FirstOrDefault(Func search) { }

	public CancellableFilter[] get_AllFilters() { }

	public int get_Count() { }

	[CompilerGenerated]
	public BindableFilterList get_HorizontalFilters() { }

	private CancellableFilter get_Item(EFilterType type) { }

	[CompilerGenerated]
	public BindableFilterList get_VerticalFilters() { }

	public bool IsActive(EFilterType type) { }

	private void ItemAddedHandler(CancellableFilter filter) { }

	private void ItemRemovedHandler(CancellableFilter filter) { }

	private void ItemsAddedHandler(IEnumerable filters) { }

	private void ItemsRemovedHandler(IEnumerable filters) { }

	[CompilerGenerated]
	public void remove_ItemAdded(Action value) { }

	[CompilerGenerated]
	public void remove_ItemRemoved(Action value) { }

	public void RemoveFilter(EFilterType filterType, bool sendCallback) { }

	public void RemoveFilter(CancellableFilter filter, bool sendCallback) { }

	public void Restore() { }

	public void Store() { }

}

