namespace EFT;

public sealed class ProfileChanges
{
	[JsonProperty("experience")]
	public int Experience; //Field offset: 0x10
	[JsonProperty("items")]
	public StashChangesResponse Stash; //Field offset: 0x18
	[JsonProperty("quests")]
	public QuestTemplate[] Quests; //Field offset: 0x20
	[JsonProperty("repeatableQuests")]
	public RepeatableQuestsRange[] RepeatableQuests; //Field offset: 0x28
	[JsonProperty("ragFairOffers")]
	public Offer[] RagFairOffers; //Field offset: 0x30
	[JsonProperty("traderRelations")]
	public Dictionary TradersData; //Field offset: 0x38
	[JsonProperty("recipeUnlocked")]
	public Dictionary UnlockedRecipes; //Field offset: 0x40
	[JsonProperty("production")]
	public Dictionary Production; //Field offset: 0x48
	[JsonProperty("improvements")]
	public Dictionary Improvements; //Field offset: 0x50
	[JsonProperty("skills")]
	public SkillsDescriptor Skills; //Field offset: 0x58
	[JsonProperty("questsStatus")]
	public QuestStatusData[] QuestsStatus; //Field offset: 0x60
	[JsonProperty("changedHideoutStashes")]
	public Dictionary HideoutAreaStashes; //Field offset: 0x68
	[JsonProperty("moneyTransferLimitData")]
	public TransferLimitsData TransferLimitsData; //Field offset: 0x70
	[JsonProperty("completableItems")]
	public Dictionary CompletableItems; //Field offset: 0x78
	[JsonProperty("newQuestNotes")]
	public MongoID[] NewQuestNotes; //Field offset: 0x80
	[JsonProperty("variableValues")]
	public Dictionary VariableValues; //Field offset: 0x88
	[JsonProperty("SeasonalPerks")]
	public MongoID[] PerkIds; //Field offset: 0x90
	[JsonProperty("SeasonalPerkEffectParameters")]
	public SeasonalPerkEffectParametersData PerkEffectParameters; //Field offset: 0x98
	[JsonProperty("SeasonalRewards")]
	public Dictionary SeasonalRewards; //Field offset: 0xA0
	[JsonProperty("battlePassUniversalDocumentBalance")]
	public Nullable BattlePassUniversalDocs; //Field offset: 0xA8

	public ProfileChanges() { }

}

