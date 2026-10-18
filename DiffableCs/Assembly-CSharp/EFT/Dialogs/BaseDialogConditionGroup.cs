namespace EFT.Dialogs;

public abstract class BaseDialogConditionGroup : DialogCondition
{
	[CompilerGenerated]
	private IReadOnlyList <Conditions>k__BackingField; //Field offset: 0x10

	[JsonProperty("Conditions")]
	public private IReadOnlyList Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected abstract ELogicalCompareMethod LogicalCompareMethod
	{
		 get { } //Length: 0
	}

	protected BaseDialogConditionGroup() { }

	protected BaseDialogConditionGroup(IReadOnlyList conditions) { }

	[CompilerGenerated]
	public IReadOnlyList get_Conditions() { }

	protected abstract ELogicalCompareMethod get_LogicalCompareMethod() { }

	[CompilerGenerated]
	private void set_Conditions(IReadOnlyList value) { }

	public virtual bool Test(IDialogContext context) { }

	public virtual string ToString() { }

}

