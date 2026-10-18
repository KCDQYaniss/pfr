namespace ChartAndGraph;

internal class ChartSparseDataSource : ChartDataSourceBase
{
	private struct KeyElement
	{
		[CompilerGenerated]
		private ChartDataRow <Row>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private ChartDataColumn <Column>k__BackingField; //Field offset: 0x8

		public private ChartDataColumn Column
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private ChartDataRow Row
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public KeyElement(ChartDataRow row, ChartDataColumn column) { }

		public virtual bool Equals(object obj) { }

		[CompilerGenerated]
		[IsReadOnly]
		public ChartDataColumn get_Column() { }

		[CompilerGenerated]
		[IsReadOnly]
		public ChartDataRow get_Row() { }

		public virtual int GetHashCode() { }

		public bool IsIn(IDataItem item) { }

		public bool IsInColumn(ChartDataColumn column) { }

		public bool IsInRow(ChartDataRow row) { }

		public static bool op_Equality(KeyElement a, KeyElement b) { }

		public static bool op_Inequality(KeyElement a, KeyElement b) { }

		[CompilerGenerated]
		private void set_Column(ChartDataColumn value) { }

		[CompilerGenerated]
		private void set_Row(ChartDataRow value) { }

	}

	private Dictionary mData; //Field offset: 0x20
	private Dictionary mChartDataToIndex; //Field offset: 0x28
	private Nullable mMaxValue; //Field offset: 0x30
	private Nullable mMinValue; //Field offset: 0x50
	private bool mFireEvent; //Field offset: 0x70
	private bool mSuspendEvents; //Field offset: 0x71
	private double[,] mRawData; //Field offset: 0x78
	public ChartColumnCollection mColumns; //Field offset: 0x80
	public ChartRowCollection mRows; //Field offset: 0x88

	public virtual ChartColumnCollection Columns
	{
		 get { } //Length: 8
	}

	public virtual ChartRowCollection Rows
	{
		 get { } //Length: 8
	}

	public bool SuspendEvents
	{
		 get { } //Length: 5
		 set { } //Length: 72
	}

	public ChartSparseDataSource() { }

	public void AddLabel(string columnName, int rowIndex, string text) { }

	public void Clear() { }

	private void Columns_ItemRemoved(ChartDataColumn obj) { }

	private void EnsureRawData() { }

	private void FindMinMaxValue() { }

	public virtual ChartColumnCollection get_Columns() { }

	public virtual ChartRowCollection get_Rows() { }

	public bool get_SuspendEvents() { }

	public virtual double[,] getRawData() { }

	internal Nullable getRawMaxValue() { }

	internal Nullable getRawMinValue() { }

	public double GetValue(string ColumnName, string RowName) { }

	public double GetValue(int columnIndex, int rowIndex) { }

	public double GetValue(string ColumnName, int rowIndex) { }

	private bool HasZeroItems() { }

	private double InnerGetValue(ChartDataColumn column, ChartDataRow row) { }

	private void InnerSetValue(ChartDataColumn column, ChartDataRow row, double amount) { }

	private void ItemRemoved(IDataItem item) { }

	private void MColumns_NameChanged(string arg1, IDataItem arg2) { }

	private void MRows_NameChanged(string arg1, IDataItem arg2) { }

	private void OrderChanged(object sender, EventArgs e) { }

	private void PrepareRawData() { }

	private void Rows_ItemRemoved(ChartDataRow obj) { }

	public void set_SuspendEvents(bool value) { }

	public void SetValue(string ColumnName, int rowIndex, double amount) { }

	public void SetValue(string ColumnName, string RowName, double amount) { }

	public void SetValue(int columnIndex, int rowIndex, double amount) { }

	private bool VerifyMinMaxValue(KeyElement element, double value) { }

}

