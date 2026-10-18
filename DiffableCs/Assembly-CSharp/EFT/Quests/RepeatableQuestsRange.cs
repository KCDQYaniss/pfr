namespace EFT.Quests;

public sealed class RepeatableQuestsRange
{
	[JsonProperty("id")]
	public readonly string Id; //Field offset: 0x10
	[JsonProperty("name")]
	public readonly string Name; //Field offset: 0x18
	[JsonProperty("unavailableTime", DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public readonly int UnavailableTime; //Field offset: 0x20
	[JsonProperty("endTime")]
	public readonly int ExpirationTime; //Field offset: 0x24
	[JsonProperty("activeQuests")]
	public RepeatableQuestTemplate[] Quests; //Field offset: 0x28
	[JsonProperty("changeRequirement")]
	public Dictionary QuestChangeRequirement; //Field offset: 0x30
	[JsonProperty("inactiveQuests", DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public RepeatableQuestTemplate[] InactiveQuests; //Field offset: 0x38
	[JsonProperty("freeChanges")]
	public int MaxFreeChanges; //Field offset: 0x40
	[JsonProperty("freeChangesAvailable")]
	public int CurrentFreeChanges; //Field offset: 0x44

	public int UpdateTime
	{
		 get { } //Length: 7
	}

	public RepeatableQuestsRange() { }

	public int get_UpdateTime() { }

	[OnDeserialized]
	internal void OnDeserializedMethod(StreamingContext context) { }

}

