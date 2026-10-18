namespace System.Data;

internal sealed class RelatedView : DataView, IFilter
{
	private readonly Nullable _parentKey; //Field offset: 0xB8
	private readonly DataKey _childKey; //Field offset: 0xC8
	private readonly DataRowView _parentRowView; //Field offset: 0xD0
	private readonly object[] _filterValues; //Field offset: 0xD8

	public RelatedView(DataColumn[] columns, object[] values) { }

	public RelatedView(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	public virtual DataRowView AddNew() { }

	internal virtual IFilter GetFilter() { }

	private object[] GetParentValues() { }

	public override bool Invoke(DataRow row, DataRowVersion version) { }

	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

