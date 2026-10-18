namespace ChartAndGraph;

internal interface IInternalGraphData
{

	public event EventHandler InternalDataChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event EventHandler InternalRealTimeDataChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IEnumerable Categories
	{
		 get { } //Length: 0
	}

	public int TotalCategories
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_InternalDataChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_InternalRealTimeDataChanged(EventHandler value) { }

	public IEnumerable get_Categories() { }

	public int get_TotalCategories() { }

	public double GetMaxValue(int axis, bool dataValue) { }

	public double GetMinValue(int axis, bool dataValue) { }

	public void OnAfterDeserialize() { }

	public void OnBeforeSerialize() { }

	[CompilerGenerated]
	public void remove_InternalDataChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_InternalRealTimeDataChanged(EventHandler value) { }

	public void Update() { }

}

