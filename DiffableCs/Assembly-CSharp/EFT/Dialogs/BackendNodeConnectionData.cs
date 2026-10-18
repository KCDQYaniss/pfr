namespace EFT.Dialogs;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class BackendNodeConnectionData
{
	[CompilerGenerated]
	private readonly MongoID <ID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly MongoID <TargetID>k__BackingField; //Field offset: 0x28

	[JsonProperty("id")]
	public MongoID ID
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	[JsonProperty("targetId")]
	public MongoID TargetID
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	[JsonConstructor]
	public BackendNodeConnectionData(MongoID id, MongoID targetID) { }

	[CompilerGenerated]
	public MongoID get_ID() { }

	[CompilerGenerated]
	public MongoID get_TargetID() { }

}

