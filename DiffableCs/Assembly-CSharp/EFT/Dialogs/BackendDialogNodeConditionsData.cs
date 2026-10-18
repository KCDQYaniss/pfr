namespace EFT.Dialogs;

public sealed class BackendDialogNodeConditionsData
{
	public readonly ELogicalCompareMethod Operator; //Field offset: 0x10
	public readonly IReadOnlyList List; //Field offset: 0x18

	public BackendDialogNodeConditionsData() { }

	[JsonConstructor]
	private BackendDialogNodeConditionsData(ELogicalCompareMethod comparator, IReadOnlyList list) { }

}

