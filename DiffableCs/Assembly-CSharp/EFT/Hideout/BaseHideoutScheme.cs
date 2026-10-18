namespace EFT.Hideout;

public abstract class BaseHideoutScheme
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <OnDeserializedMethod>b__29_0(Requirement x, Requirement y) { }

	}

	private static readonly HashSet _itemDuplicates; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnAddToFavorite; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnRemoveFromFavorite; //Field offset: 0x18
	[JsonProperty("_id")]
	public string _id; //Field offset: 0x20
	[JsonProperty("count")]
	public int count; //Field offset: 0x28
	[JsonProperty("continuous")]
	public bool continuous; //Field offset: 0x2C
	[JsonProperty("productionLimitCount")]
	public int productionLimitCount; //Field offset: 0x30
	[JsonProperty("isCodeProduction")]
	public bool isCodeProduction; //Field offset: 0x34
	public int areaType; //Field offset: 0x38
	public float productionTime; //Field offset: 0x3C
	public bool needFuelForAllProductionTime; //Field offset: 0x40
	public bool locked; //Field offset: 0x41
	public int Level; //Field offset: 0x44
	public Requirement[] requirements; //Field offset: 0x48

	public event Action OnAddToFavorite
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnRemoveFromFavorite
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int FavoriteIndex
	{
		 get { } //Length: 111
	}

	public bool FavoriteScheme
	{
		 get { } //Length: 97
		 set { } //Length: 658
	}

	public bool HasRequirements
	{
		 get { } //Length: 22
	}

	public IEnumerable RequiredItems
	{
		 get { } //Length: 63
	}

	public override EOwnerType SchemeOwnerType
	{
		 get { } //Length: 6
	}

	private static BaseHideoutScheme() { }

	protected BaseHideoutScheme() { }

	[CompilerGenerated]
	public void add_OnAddToFavorite(Action value) { }

	[CompilerGenerated]
	public void add_OnRemoveFromFavorite(Action value) { }

	private void CheckItemDuplicates() { }

	public int get_FavoriteIndex() { }

	public bool get_FavoriteScheme() { }

	public bool get_HasRequirements() { }

	public IEnumerable get_RequiredItems() { }

	public override EOwnerType get_SchemeOwnerType() { }

	public ProducingItemController GetProducingItem(float speedCoefficient, float reductionCoefficient = 1) { }

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context) { }

	[CompilerGenerated]
	public void remove_OnAddToFavorite(Action value) { }

	[CompilerGenerated]
	public void remove_OnRemoveFromFavorite(Action value) { }

	public void set_FavoriteScheme(bool value) { }

	private void SetSchemeLevel() { }

}

