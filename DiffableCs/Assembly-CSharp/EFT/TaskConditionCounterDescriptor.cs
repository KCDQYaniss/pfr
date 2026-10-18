namespace EFT;

[BinaryReaderCompatible("ReadTaskConditionCounterDescriptor", "WriteTaskConditionCounterDescriptor")]
public sealed class TaskConditionCounterDescriptor
{
	[JsonProperty("id")]
	public MongoID Id; //Field offset: 0x10
	[JsonProperty("value")]
	public int Value; //Field offset: 0x28
	[JsonProperty("sourceId")]
	public string SourceId; //Field offset: 0x30
	[JsonProperty("type")]
	public string Type; //Field offset: 0x38

	public TaskConditionCounterDescriptor() { }

	public TaskConditionCounterDescriptor(TaskConditionCounter counter) { }

}

