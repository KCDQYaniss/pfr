namespace EFT;

public sealed class OtherPlayerProfileDescriptor
{
	internal sealed class BattlePassProgressData : SeasonalProgressData
	{
		[JsonProperty("battlePassId")]
		public MongoID Id; //Field offset: 0x18

		public BattlePassProgressData() { }

	}

	internal class SeasonalProgressData
	{
		[JsonProperty("completed")]
		public int Completed; //Field offset: 0x10
		[JsonProperty("total")]
		public int Total; //Field offset: 0x14

		public SeasonalProgressData() { }

	}

	internal sealed class SeasonalRewardProgressData : SeasonalProgressData
	{
		[JsonProperty("seasonalRewardId")]
		public MongoID Id; //Field offset: 0x18

		public SeasonalRewardProgressData() { }

	}

	[JsonProperty("favoriteItems")]
	public FlatItem[] FavoriteItems; //Field offset: 0x10
	[JsonProperty("aid")]
	public string AccountId; //Field offset: 0x18
	[JsonProperty("info")]
	public OtherPlayerInfo Info; //Field offset: 0x20
	[JsonProperty("achievements")]
	public Dictionary AchievementsData; //Field offset: 0x28
	[JsonProperty("customization")]
	public Dictionary Customization; //Field offset: 0x30
	[JsonProperty("equipment")]
	public InventoryEquipmentDescriptor Equipment; //Field offset: 0x38
	[JsonProperty("pmcStats")]
	public ProfileStatsSeparatorDescriptor PmcStats; //Field offset: 0x40
	[JsonProperty("scavStats")]
	public ProfileStatsSeparatorDescriptor ScavStats; //Field offset: 0x48
	[JsonProperty("skills")]
	public SkillsDescriptor Skills; //Field offset: 0x50
	[JsonProperty("hideout")]
	public readonly HideoutInfo Hideout; //Field offset: 0x58
	[JsonProperty("Ending")]
	public EndingInfo Ending; //Field offset: 0x60
	[JsonProperty("selectedSeasonalPerkIds")]
	private MongoID[] _selectedSeasonalPerkIds; //Field offset: 0x68
	[JsonProperty("battlePassProgress")]
	private BattlePassProgressData[] _battlePassProgress; //Field offset: 0x70
	[JsonProperty("seasonalRewardsProgress")]
	private SeasonalRewardProgressData[] _seasonalRewardsProgress; //Field offset: 0x78
	[JsonProperty("hideoutAreaStashes", NullValueHandling = NullValueHandling::Ignore (1))]
	private Dictionary _hideoutAreaStashesIds; //Field offset: 0x80
	[JsonProperty("customizationStash")]
	private Nullable _customizationStashId; //Field offset: 0x88
	[JsonProperty("items")]
	private FlatItem[] _items; //Field offset: 0xA8
	public HideoutData HideoutData; //Field offset: 0xB0

	public IReadOnlyList BattlePassProgress
	{
		 get { } //Length: 74
	}

	public IReadOnlyList SeasonalRewardsProgress
	{
		 get { } //Length: 74
	}

	public IReadOnlyList SelectedSeasonalPerkIds
	{
		 get { } //Length: 67
	}

	public OtherPlayerProfileDescriptor() { }

	public IReadOnlyList get_BattlePassProgress() { }

	public IReadOnlyList get_SeasonalRewardsProgress() { }

	public IReadOnlyList get_SelectedSeasonalPerkIds() { }

	[OnDeserialized]
	private void OnDeserializing(StreamingContext context) { }

}

