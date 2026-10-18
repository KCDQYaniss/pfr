//Type is in global namespace

public class CategoryLabels : AlignedItemLabels
{
	internal enum ChartCategoryLabelOptions
	{
		All = 0,
		FirstOnly = 1,
	}

	[SerializeField]
	[Tooltip("Determines which labels are visible")]
	private ChartCategoryLabelOptions visibleLabels; //Field offset: 0x68

	protected virtual Action Assign
	{
		 get { } //Length: 113
	}

	public ChartCategoryLabelOptions VisibleLabels
	{
		 get { } //Length: 4
		 set { } //Length: 23
	}

	public CategoryLabels() { }

	[CompilerGenerated]
	private void <get_Assign>b__6_0(IInternalUse x, bool clear) { }

	protected virtual Action get_Assign() { }

	public ChartCategoryLabelOptions get_VisibleLabels() { }

	public void set_VisibleLabels(ChartCategoryLabelOptions value) { }

}

