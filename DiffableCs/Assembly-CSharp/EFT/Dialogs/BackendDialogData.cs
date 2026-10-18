namespace EFT.Dialogs;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class BackendDialogData
{
	[JsonProperty("id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("traderId")]
	public readonly MongoID TraderID; //Field offset: 0x28
	[JsonProperty("name")]
	public readonly string Name; //Field offset: 0x40
	[JsonProperty("nodes")]
	private readonly List _nodes; //Field offset: 0x48
	[JsonProperty("connections")]
	private readonly List _connections; //Field offset: 0x50
	private readonly Dictionary _nodesCache; //Field offset: 0x58
	private readonly List _splitters; //Field offset: 0x60
	private readonly List _lines; //Field offset: 0x68
	private readonly Dictionary _parents; //Field offset: 0x70
	[CompilerGenerated]
	private TraderDialogTemplate <DialogTemplate>k__BackingField; //Field offset: 0x78

	public private TraderDialogTemplate DialogTemplate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IReadOnlyList Lines
	{
		 get { } //Length: 5
	}

	[JsonConstructor]
	public BackendDialogData(MongoID id, MongoID traderID, string name, List nodes, List connections) { }

	private void AddMainSaveVariable(in Dictionary saveVariablesContainer, MongoID nodeId, int variableValue, ESaveStateType saveType) { }

	private void Convert() { }

	private Dictionary GenerateLocalizationDictionary() { }

	[CompilerGenerated]
	public TraderDialogTemplate get_DialogTemplate() { }

	public IReadOnlyList get_Lines() { }

	private MongoID[] GetSubTraders() { }

	private void Init() { }

	[CompilerGenerated]
	private void set_DialogTemplate(TraderDialogTemplate value) { }

}

