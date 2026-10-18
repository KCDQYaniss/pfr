namespace EFT;

[GenerateBinarySerialization]
public class ProfileDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__40_0; //Field offset: 0x8
		public static Func <>9__40_1; //Field offset: 0x10
		public static Func <>9__40_2; //Field offset: 0x18
		public static Func <>9__40_3; //Field offset: 0x20
		public static Func <>9__40_4; //Field offset: 0x28
		public static Func <>9__40_5; //Field offset: 0x30
		public static Func <>9__40_6; //Field offset: 0x38
		public static Func <>9__40_7; //Field offset: 0x40
		public static Func <>9__40_8; //Field offset: 0x48
		public static Func <>9__40_9; //Field offset: 0x50
		public static Func <>9__40_10; //Field offset: 0x58
		public static Func <>9__40_11; //Field offset: 0x60
		public static Func <>9__40_12; //Field offset: 0x68
		public static Func <>9__40_13; //Field offset: 0x70
		public static Func <>9__40_14; //Field offset: 0x78
		public static Func <>9__40_15; //Field offset: 0x80
		public static Func <>9__40_16; //Field offset: 0x88
		public static Func <>9__40_17; //Field offset: 0x90
		public static Func <>9__41_0; //Field offset: 0x98
		public static Func <>9__41_1; //Field offset: 0xA0
		public static Func <>9__41_2; //Field offset: 0xA8
		public static Func <>9__41_3; //Field offset: 0xB0
		public static Func <>9__41_4; //Field offset: 0xB8
		public static Func <>9__41_5; //Field offset: 0xC0
		public static Func <>9__41_6; //Field offset: 0xC8
		public static Func <>9__41_7; //Field offset: 0xD0
		public static Func <>9__41_8; //Field offset: 0xD8
		public static Func <>9__41_9; //Field offset: 0xE0
		public static Func <>9__41_10; //Field offset: 0xE8
		public static Func <>9__41_11; //Field offset: 0xF0
		public static Func <>9__41_12; //Field offset: 0xF8
		public static Func <>9__41_13; //Field offset: 0x100
		public static Func <>9__41_14; //Field offset: 0x108
		public static Func <>9__41_15; //Field offset: 0x110
		public static Func <>9__41_16; //Field offset: 0x118
		public static Func <>9__41_17; //Field offset: 0x120

		private static <>c() { }

		public <>c() { }

		internal EBodyModelPart <.ctor>b__40_0(KeyValuePair item) { }

		internal MongoID <.ctor>b__40_1(KeyValuePair item) { }

		internal MongoID <.ctor>b__40_10(KeyValuePair pair) { }

		internal BattlePassDocumentLimitData <.ctor>b__40_11(KeyValuePair pair) { }

		internal MongoID <.ctor>b__40_12(KeyValuePair pair) { }

		internal TraderInfoDescriptor <.ctor>b__40_13(KeyValuePair pair) { }

		internal MongoID <.ctor>b__40_14(KeyValuePair pair) { }

		internal int <.ctor>b__40_15(KeyValuePair pair) { }

		internal MongoID <.ctor>b__40_16(KeyValuePair key) { }

		internal bool <.ctor>b__40_17(KeyValuePair value) { }

		internal MongoID <.ctor>b__40_2(KeyValuePair item) { }

		internal TaskConditionCounterDescriptor <.ctor>b__40_3(KeyValuePair item) { }

		internal MongoID <.ctor>b__40_4(KeyValuePair pair) { }

		internal byte <.ctor>b__40_5(KeyValuePair pair) { }

		internal MongoID <.ctor>b__40_6(KeyValuePair pair) { }

		internal int <.ctor>b__40_7(KeyValuePair pair) { }

		internal MongoID <.ctor>b__40_8(PrestigeStatusData data) { }

		internal int <.ctor>b__40_9(PrestigeStatusData data) { }

		internal EBodyModelPart <.ctor>b__41_0(KeyValuePair item) { }

		internal MongoID <.ctor>b__41_1(KeyValuePair item) { }

		internal MongoID <.ctor>b__41_10(KeyValuePair pair) { }

		internal BattlePassDocumentLimitData <.ctor>b__41_11(KeyValuePair pair) { }

		internal MongoID <.ctor>b__41_12(KeyValuePair pair) { }

		internal TraderInfoDescriptor <.ctor>b__41_13(KeyValuePair pair) { }

		internal MongoID <.ctor>b__41_14(KeyValuePair pair) { }

		internal int <.ctor>b__41_15(KeyValuePair pair) { }

		internal MongoID <.ctor>b__41_16(KeyValuePair key) { }

		internal bool <.ctor>b__41_17(KeyValuePair value) { }

		internal MongoID <.ctor>b__41_2(KeyValuePair item) { }

		internal TaskConditionCounterDescriptor <.ctor>b__41_3(KeyValuePair item) { }

		internal MongoID <.ctor>b__41_4(KeyValuePair pair) { }

		internal byte <.ctor>b__41_5(KeyValuePair pair) { }

		internal MongoID <.ctor>b__41_6(KeyValuePair pair) { }

		internal int <.ctor>b__41_7(KeyValuePair pair) { }

		internal MongoID <.ctor>b__41_8(PrestigeStatusData data) { }

		internal int <.ctor>b__41_9(PrestigeStatusData data) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__ClonePolymorph; //Field offset: 0x0

	}

	[JsonProperty("_id")]
	public MongoID Id; //Field offset: 0x10
	[JsonProperty("aid")]
	public string AccountId; //Field offset: 0x28
	[JsonProperty("savage")]
	public Nullable PetId; //Field offset: 0x30
	[JsonProperty("karmaValue")]
	public float KarmaValue; //Field offset: 0x50
	[JsonProperty("Info")]
	public ProfileInfoDescriptor Info; //Field offset: 0x58
	[JsonProperty("Customization")]
	public Dictionary Customization; //Field offset: 0x60
	[CanBeNull]
	[JsonProperty("Encyclopedia")]
	[Nullable]
	public Dictionary Encyclopedia; //Field offset: 0x68
	[CanBeNull]
	[JsonProperty("Health")]
	[Nullable]
	public HealthInfo Health; //Field offset: 0x70
	[JsonProperty("Inventory")]
	public InventoryDescriptor Inventory; //Field offset: 0x78
	[JsonProperty("InsuredItems")]
	public InsuredProfileItems[] InsuredItems; //Field offset: 0x80
	[JsonProperty("Skills")]
	public SkillsDescriptor Skills; //Field offset: 0x88
	[JsonProperty("Notes")]
	public NotesDescriptor Notes; //Field offset: 0x90
	[JsonProperty("TaskConditionCounters")]
	public Dictionary TaskConditionCounters; //Field offset: 0x98
	[JsonProperty("Quests")]
	public List QuestsData; //Field offset: 0xA0
	[JsonProperty("Achievements")]
	public Dictionary AchievementsData; //Field offset: 0xA8
	[JsonProperty("Prestige")]
	public Dictionary PrestigeData; //Field offset: 0xB0
	[JsonProperty("Variables")]
	public Dictionary VariableData; //Field offset: 0xB8
	[JsonProperty("SeasonalPerks")]
	public HashSet PerkIds; //Field offset: 0xC0
	[JsonProperty("SeasonalPerkEffectParameters")]
	public SeasonalPerkEffectParametersData PerkEffectParameters; //Field offset: 0xC8
	[JsonProperty("SeasonalRewards")]
	public Dictionary SeasonalRewards; //Field offset: 0xD0
	[JsonProperty("moneyTransferLimitData")]
	public MoneyTransferLimitData TransferLimitData; //Field offset: 0xD8
	[JsonProperty("battlePassDocumentLimitData")]
	public Dictionary BattlePassDocumentLimitData; //Field offset: 0xE0
	[JsonProperty("Bonuses")]
	public BonusDescriptor[] Bonuses; //Field offset: 0xE8
	[IgnoreBinarySerialization]
	[JsonProperty("Hideout")]
	public HideoutInfo Hideout; //Field offset: 0xF0
	[IgnoreBinarySerialization]
	[JsonProperty("RagfairInfo")]
	public ProfileRagfairInfo RagfairInfo; //Field offset: 0xF8
	[IgnoreBinarySerialization]
	[JsonProperty("UnlockedInfo")]
	public UnlockedInfo UnlockedRecipeInfo; //Field offset: 0x100
	[JsonProperty("WishList")]
	public Dictionary WishList; //Field offset: 0x108
	[JsonProperty("Stats")]
	public ProfileStatsSeparatorDescriptor Stats; //Field offset: 0x110
	[JsonProperty("CheckedMagazines")]
	public Dictionary CheckedMagazines; //Field offset: 0x118
	[JsonProperty("CheckedChambers")]
	public List CheckedChambers; //Field offset: 0x120
	[JsonProperty("TradersInfo")]
	public Dictionary TradersInfo; //Field offset: 0x128
	[JsonProperty("CompletableItems")]
	public Dictionary CompletableItems; //Field offset: 0x130
	[JsonProperty("QuestNotes")]
	public Dictionary QuestNotes; //Field offset: 0x138
	[JsonProperty("ReadQuestData")]
	public HashSet ReadQuestData; //Field offset: 0x140
	[JsonProperty("Ending")]
	public EndingInfo Ending; //Field offset: 0x148
	[JsonProperty("UnlockedLocations")]
	public HashSet UnlockedLocations; //Field offset: 0x150
	[JsonProperty("BattlePassUniversalDocumentBalance")]
	public int UniversalDocuments; //Field offset: 0x158
	[JsonProperty("BattlePassProgress", NullValueHandling = NullValueHandling::Ignore (1))]
	public List BattlePassProgress; //Field offset: 0x160
	[CanBeNull]
	[IgnoreBinarySerialization]
	[JsonProperty("PDT")]
	public PdtProfileRelationsDescriptor Pdt; //Field offset: 0x168

	public ProfileDescriptor() { }

	public ProfileDescriptor(Profile profile, ISearchController searchController) { }

	public ProfileDescriptor(Profile profile, Profile donorProfileForSavage, ISearchController searchController) { }

	public void ApplyPdtToInfo() { }

	private static PdtProfileRelationsDescriptor CreatePdt(ProfileInfo info) { }

	[OnDeserialized]
	private void OnJSONDeserialized(StreamingContext context) { }

}

