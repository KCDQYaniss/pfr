namespace ChartAndGraph;

public abstract class AlignedItemLabels : ItemLabelsBase
{
	[SerializeField]
	[Tooltip("Select the alignment of the label relative to the item")]
	private ChartLabelAlignment alignment; //Field offset: 0x60

	public ChartLabelAlignment Alignment
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	protected AlignedItemLabels() { }

	public ChartLabelAlignment get_Alignment() { }

	public void set_Alignment(ChartLabelAlignment value) { }

}

