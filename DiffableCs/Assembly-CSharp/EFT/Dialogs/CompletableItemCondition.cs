namespace EFT.Dialogs;

public sealed class CompletableItemCondition : DialogCondition
{
	[CompilerGenerated]
	private MongoID <CompletableItemId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsCompleted>k__BackingField; //Field offset: 0x28

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

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public CompletableItemCondition(MongoID completableItemId, bool isCompleted) { }

	public CompletableItemCondition() { }

	[CompilerGenerated]
	public MongoID get_CompletableItemId() { }

	[CompilerGenerated]
	public bool get_IsCompleted() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_CompletableItemId(MongoID value) { }

	[CompilerGenerated]
	private void set_IsCompleted(bool value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

