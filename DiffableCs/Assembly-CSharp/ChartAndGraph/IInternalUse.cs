namespace ChartAndGraph;

public interface IInternalUse
{

	public event Action Generated
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public CategoryLabels CategoryLabels
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public GroupLabels GroupLabels
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool HideHierarchy
	{
		 get { } //Length: 0
	}

	public HorizontalAxis HorizontalAxis
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool InternalSupportsCategoryLables
	{
		 get { } //Length: 0
	}

	public bool InternalSupportsGroupLabels
	{
		 get { } //Length: 0
	}

	public bool InternalSupportsItemLabels
	{
		 get { } //Length: 0
	}

	public Camera InternalTextCamera
	{
		 get { } //Length: 0
	}

	public TextController InternalTextController
	{
		 get { } //Length: 0
	}

	public float InternalTextIdleDistance
	{
		 get { } //Length: 0
	}

	public float InternalTotalDepth
	{
		 get { } //Length: 0
	}

	public float InternalTotalHeight
	{
		 get { } //Length: 0
	}

	public float InternalTotalWidth
	{
		 get { } //Length: 0
	}

	public ItemLabels ItemLabels
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public VerticalAxis VerticalAxis
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_Generated(Action value) { }

	public void CallOnValidate() { }

	public CategoryLabels get_CategoryLabels() { }

	public GroupLabels get_GroupLabels() { }

	public bool get_HideHierarchy() { }

	public HorizontalAxis get_HorizontalAxis() { }

	public bool get_InternalSupportsCategoryLables() { }

	public bool get_InternalSupportsGroupLabels() { }

	public bool get_InternalSupportsItemLabels() { }

	public Camera get_InternalTextCamera() { }

	public TextController get_InternalTextController() { }

	public float get_InternalTextIdleDistance() { }

	public float get_InternalTotalDepth() { }

	public float get_InternalTotalHeight() { }

	public float get_InternalTotalWidth() { }

	public ItemLabels get_ItemLabels() { }

	public VerticalAxis get_VerticalAxis() { }

	public bool InternalHasValues(AxisBase axis) { }

	public void InternalItemHovered(object userData) { }

	public void InternalItemLeave(object userData) { }

	public void InternalItemSelected(object userData) { }

	public double InternalMaxValue(AxisBase axis) { }

	public double InternalMinValue(AxisBase axis) { }

	[CompilerGenerated]
	public void remove_Generated(Action value) { }

	public void set_CategoryLabels(CategoryLabels value) { }

	public void set_GroupLabels(GroupLabels value) { }

	public void set_HorizontalAxis(HorizontalAxis value) { }

	public void set_ItemLabels(ItemLabels value) { }

	public void set_VerticalAxis(VerticalAxis value) { }

}

