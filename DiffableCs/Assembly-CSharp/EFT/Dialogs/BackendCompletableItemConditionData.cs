namespace EFT.Dialogs;

public sealed class BackendCompletableItemConditionData : BackendDialogNodeConditionData
{
	[CompilerGenerated]
	private MongoID <CompletableItemId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x40

	[JsonProperty("completableItemId")]
	public private MongoID CompletableItemId
	{
		[CompilerGenerated]
		 get { } //Length: 21
		[CompilerGenerated]
		private set { } //Length: 98
	}

	[JsonProperty("isCompleted")]
	public private bool IsCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual EConditionType Type
	{
		 get { } //Length: 6
	}

	public BackendCompletableItemConditionData() { }

	[CompilerGenerated]
	public MongoID get_CompletableItemId() { }

	[CompilerGenerated]
	public bool get_IsCompleted() { }

	public virtual EConditionType get_Type() { }

	[CompilerGenerated]
	private void set_CompletableItemId(MongoID value) { }

	[CompilerGenerated]
	private void set_IsCompleted(bool value) { }

	public virtual DialogCondition ToDialogCondition() { }

}

