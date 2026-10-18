namespace EFT.Dialogs;

public sealed class DialogConditionSubGroup : BaseDialogConditionGroup
{

	protected virtual ELogicalCompareMethod LogicalCompareMethod
	{
		 get { } //Length: 3
	}

	public virtual EDialogConditionType Type
	{
		 get { } //Length: 6
	}

	public DialogConditionSubGroup() { }

	public DialogConditionSubGroup(IReadOnlyList conditions) { }

	protected virtual ELogicalCompareMethod get_LogicalCompareMethod() { }

	public virtual EDialogConditionType get_Type() { }

}

