namespace ChartAndGraph.DataSource;

internal abstract class ChartDataSourceBase
{
	internal class DataValueChangedEventArgs : EventArgs
	{
		[CompilerGenerated]
		private ChartItemIndex <ItemIndex>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private double <OldValue>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private double <NewValue>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private bool <MinMaxChanged>k__BackingField; //Field offset: 0x28

		public private ChartItemIndex ItemIndex
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public private bool MinMaxChanged
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private double NewValue
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public private double OldValue
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			private set { } //Length: 6
		}

		public DataValueChangedEventArgs(int group, int category, double oldValue, double newValue, bool minMaxChanged) { }

		[CompilerGenerated]
		public ChartItemIndex get_ItemIndex() { }

		[CompilerGenerated]
		public bool get_MinMaxChanged() { }

		[CompilerGenerated]
		public double get_NewValue() { }

		[CompilerGenerated]
		public double get_OldValue() { }

		[CompilerGenerated]
		private void set_ItemIndex(ChartItemIndex value) { }

		[CompilerGenerated]
		private void set_MinMaxChanged(bool value) { }

		[CompilerGenerated]
		private void set_NewValue(double value) { }

		[CompilerGenerated]
		private void set_OldValue(double value) { }

	}

	[CompilerGenerated]
	private EventHandler DataStructureChanged; //Field offset: 0x10
	[CompilerGenerated]
	private EventHandler DataValueChanged; //Field offset: 0x18

	public event EventHandler DataStructureChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler DataValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public abstract ChartColumnCollection Columns
	{
		 get { } //Length: 0
	}

	public abstract ChartRowCollection Rows
	{
		 get { } //Length: 0
	}

	protected ChartDataSourceBase() { }

	[CompilerGenerated]
	public void add_DataStructureChanged(EventHandler value) { }

	[CompilerGenerated]
	public void add_DataValueChanged(EventHandler value) { }

	public abstract ChartColumnCollection get_Columns() { }

	public abstract ChartRowCollection get_Rows() { }

	public abstract double[,] getRawData() { }

	protected void OnDataStructureChanged() { }

	protected void OnDataValueChanged(DataValueChangedEventArgs data) { }

	[CompilerGenerated]
	public void remove_DataStructureChanged(EventHandler value) { }

	[CompilerGenerated]
	public void remove_DataValueChanged(EventHandler value) { }

}

