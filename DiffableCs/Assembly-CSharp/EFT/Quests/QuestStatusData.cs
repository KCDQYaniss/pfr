namespace EFT.Quests;

[BinaryReaderCompatible("ReadQuestStatusData", "WriteQuestStatusData")]
public sealed class QuestStatusData
{
	[JsonProperty("qid")]
	public string Id; //Field offset: 0x10
	[JsonProperty("startTime")]
	public int StartTime; //Field offset: 0x18
	[JsonProperty("status")]
	public EQuestStatus Status; //Field offset: 0x1C
	[JsonProperty("statusTimers")]
	public Dictionary StatusStartTimestamps; //Field offset: 0x20
	[JsonProperty("completedConditions")]
	public HashSet CompletedConditions; //Field offset: 0x28
	[JsonProperty("availableAfter")]
	public int AvailableAfter; //Field offset: 0x30
	[CanBeNull]
	[IgnoreBinarySerialization]
	[JsonIgnore]
	public QuestTemplate Template; //Field offset: 0x38
	[CanBeNull]
	[IgnoreBinarySerialization]
	[JsonIgnore]
	public Quest Quest; //Field offset: 0x40

	public QuestStatusData() { }

	public void Update(QuestStatusData data) { }

}

