namespace EFT.Prestige;

public sealed class PrestigeTemplate
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_0; //Field offset: 0x8
		public static Func <>9__12_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal Type <.ctor>b__12_0(KeyValuePair kvp) { }

		internal IEnumerable <.ctor>b__12_1(KeyValuePair kvp) { }

	}

	internal sealed class ItemsTransferConfig
	{
		internal sealed class AbilitiesConfig
		{
			public readonly float Multiplier; //Field offset: 0x10

			[JsonConstructor]
			private AbilitiesConfig(float multiplier) { }

		}

		internal sealed class TransferStashConfig
		{
			internal sealed class ItemFilter
			{
				[JsonArray]
				internal sealed class UnifiedHandbookEntities : HandbookEntities
				{

					[JsonConstructor]
					private UnifiedHandbookEntities(IEnumerable entities) { }

					private static IReadOnlyCollection ConvertIds(IEnumerable entities) { }

				}

				private readonly UnifiedHandbookEntities _includedItems; //Field offset: 0x10
				private readonly UnifiedHandbookEntities _excludedItems; //Field offset: 0x18

				[JsonConstructor]
				private ItemFilter(UnifiedHandbookEntities includedItems, UnifiedHandbookEntities excludedItems) { }

				public bool Contains(ItemTemplate item) { }

			}

			[CompilerGenerated]
			private readonly Vector2Int <Size>k__BackingField; //Field offset: 0x10
			public readonly ItemFilter Filters; //Field offset: 0x18

			public Vector2Int Size
			{
				[CompilerGenerated]
				 get { } //Length: 5
			}

			[JsonConstructor]
			private TransferStashConfig(int width, int height, ItemFilter filters) { }

			[CompilerGenerated]
			public Vector2Int get_Size() { }

		}

		public readonly TransferStashConfig StashConfig; //Field offset: 0x10
		public readonly AbilitiesConfig Skills; //Field offset: 0x18
		public readonly AbilitiesConfig Mastering; //Field offset: 0x20

		[JsonConstructor]
		private ItemsTransferConfig(TransferStashConfig stashConfig, AbilitiesConfig skills, AbilitiesConfig mastering) { }

	}

	public readonly MongoID Id; //Field offset: 0x10
	public readonly ImageData Icon; //Field offset: 0x28
	public readonly ImageData Image; //Field offset: 0x30
	public readonly IReadOnlyList Conditions; //Field offset: 0x38
	public readonly IReadOnlyList Rewards; //Field offset: 0x40
	public readonly ItemsTransferConfig TransferConfig; //Field offset: 0x48
	public readonly IReadOnlyDictionary SortedConditions; //Field offset: 0x50

	public string Description
	{
		 get { } //Length: 281
	}

	public string Title
	{
		 get { } //Length: 281
	}

	[JsonConstructor]
	private PrestigeTemplate(MongoID id, string iconUrl, string imageUrl, List conditions, List rewards, ItemsTransferConfig transferConfig) { }

	public string get_Description() { }

	public string get_Title() { }

}

