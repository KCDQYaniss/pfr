namespace EFT.Dialogs;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class BackendDialogNodeData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public MongoID output; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <Init>b__0(BackendNodeConnectionData con) { }

	}

	[JsonConverter(typeof(EFT.EnumConverter`1<EFT.Dialogs.BackendDialogNodeData+EBackendDialogNodeType>))]
	internal enum EBackendDialogNodeType
	{
		Splitter = 0,
		Npc = 1,
		Player = 2,
	}

	[JsonProperty("id")]
	public readonly MongoID ID; //Field offset: 0x10
	[JsonProperty("type")]
	public readonly EBackendDialogNodeType Type; //Field offset: 0x28
	[JsonProperty("text")]
	public readonly string Text; //Field offset: 0x30
	[JsonProperty("clientIcon")]
	public readonly Nullable IconType; //Field offset: 0x38
	[JsonProperty("checkpointType")]
	public readonly ESaveStateType CheckpointType; //Field offset: 0x40
	[JsonProperty("random")]
	public readonly Nullable Random; //Field offset: 0x44
	[JsonProperty("randomGroupId")]
	public readonly Nullable RandomGroupId; //Field offset: 0x4C
	[JsonProperty("conditionGroup")]
	public readonly BackendDialogNodeMainConditionData MainCondition; //Field offset: 0x58
	[JsonProperty("actions")]
	public readonly IReadOnlyList Actions; //Field offset: 0x60
	[CompilerGenerated]
	private BackendCombinedAnimationData <Playback>k__BackingField; //Field offset: 0x68
	public readonly bool IsSplitter; //Field offset: 0x70
	[JsonProperty("confirmationKey")]
	public readonly string ConfirmationKey; //Field offset: 0x78
	[JsonProperty("outputs")]
	private readonly MongoID[] _outputs; //Field offset: 0x80
	private readonly List _children; //Field offset: 0x88

	public IEnumerable Children
	{
		 get { } //Length: 8
	}

	[JsonProperty("playback")]
	public private BackendCombinedAnimationData Playback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[JsonConstructor]
	public BackendDialogNodeData(MongoID id, EBackendDialogNodeType type, MongoID[] outputs, string text, string iconType, Nullable random, BackendDialogNodeMainConditionData mainCondition, IReadOnlyList actions, ESaveStateType checkpointType, BackendCombinedAnimationData playback, string confirmationKey) { }

	public IEnumerable get_Children() { }

	[CompilerGenerated]
	public BackendCombinedAnimationData get_Playback() { }

	public void Init(IReadOnlyList connections) { }

	[CompilerGenerated]
	private void set_Playback(BackendCombinedAnimationData value) { }

	public void SetAnimationData(BackendCombinedAnimationData animationData) { }

}

