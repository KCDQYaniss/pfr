namespace EFT.Dialogs;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class ProgressDialogData
{
	[JsonProperty("traderId")]
	public MongoID TraderId; //Field offset: 0x10
	[JsonProperty("dialogueId")]
	public MongoID DialogId; //Field offset: 0x28
	[JsonProperty("nodeId")]
	public MongoID LineId; //Field offset: 0x40
	public readonly IReadOnlyCollection ItemsToHandover; //Field offset: 0x58

	public ProgressDialogData(MongoID traderId, MongoID dialogId, MongoID lineId, IReadOnlyCollection itemsToHandover) { }

}

