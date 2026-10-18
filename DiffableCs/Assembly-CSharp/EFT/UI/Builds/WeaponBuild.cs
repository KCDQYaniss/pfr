namespace EFT.UI.Builds;

public sealed class WeaponBuild
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8
		public static Func <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <set_Item>b__10_0(Item x) { }

		internal string <set_Item>b__10_1(Item x) { }

	}

	[CompilerGenerated]
	private MongoID <Id>k__BackingField; //Field offset: 0x10
	public readonly string ItemIconName; //Field offset: 0x28
	public readonly string HandbookName; //Field offset: 0x30
	public readonly bool FromPreset; //Field offset: 0x38
	private Item _item; //Field offset: 0x40
	[CompilerGenerated]
	private IReadOnlyCollection <IncludedItems>k__BackingField; //Field offset: 0x48

	public private MongoID Id
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	public private IReadOnlyCollection IncludedItems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private Item Item
	{
		 get { } //Length: 5
		private set { } //Length: 1419
	}

	public WeaponBuild(MongoID id, string itemIconName, string handbookName, Item item, bool fromPreset) { }

	[JsonConstructor]
	private WeaponBuild(MongoID id, string name, MongoID rootItem, FlatItem[] items) { }

	private WeaponBuild(MongoID id, string itemIconName, string handbookName, bool fromPreset) { }

	[CompilerGenerated]
	public MongoID get_Id() { }

	[CompilerGenerated]
	public IReadOnlyCollection get_IncludedItems() { }

	public Item get_Item() { }

	[CompilerGenerated]
	private void set_Id(MongoID value) { }

	[CompilerGenerated]
	private void set_IncludedItems(IReadOnlyCollection value) { }

	private void set_Item(Item value) { }

	public virtual string ToString() { }

}

