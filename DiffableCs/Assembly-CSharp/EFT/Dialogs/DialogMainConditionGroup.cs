namespace EFT.Dialogs;

public class DialogMainConditionGroup : BaseDialogConditionGroup
{
	[CompilerGenerated]
	private RandomLineCondition <Random>k__BackingField; //Field offset: 0x18

	protected virtual ELogicalCompareMethod LogicalCompareMethod
	{
		 get { } //Length: 6
	}

	[JsonProperty("Random", DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public private RandomLineCondition Random
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public DialogMainConditionGroup() { }

	public DialogMainConditionGroup(IReadOnlyList conditions, RandomLineCondition random = null) { }

	protected virtual ELogicalCompareMethod get_LogicalCompareMethod() { }

	[CompilerGenerated]
	public RandomLineCondition get_Random() { }

	public virtual EDialogConditionType get_Type() { }

	[CompilerGenerated]
	private void set_Random(RandomLineCondition value) { }

	public virtual bool Test(IDialogContext context) { }

}

