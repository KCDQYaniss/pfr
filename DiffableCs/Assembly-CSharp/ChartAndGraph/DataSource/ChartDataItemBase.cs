namespace ChartAndGraph.DataSource;

internal abstract class ChartDataItemBase : IDataItem
{
	private string mName; //Field offset: 0x10
	private string mPrevName; //Field offset: 0x18
	[CompilerGenerated]
	private object <UserData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ChartDynamicMaterial <Material>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Action NameChanged; //Field offset: 0x30

	public override event Action NameChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public ChartDynamicMaterial Material
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override string Name
	{
		 get { } //Length: 5
		 set { } //Length: 219
	}

	public object UserData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public ChartDataItemBase(string name) { }

	[CompilerGenerated]
	public override void add_NameChanged(Action value) { }

	public override void CancelNameChange() { }

	[CompilerGenerated]
	public ChartDynamicMaterial get_Material() { }

	public override string get_Name() { }

	[CompilerGenerated]
	public object get_UserData() { }

	[CompilerGenerated]
	public override void remove_NameChanged(Action value) { }

	[CompilerGenerated]
	public void set_Material(ChartDynamicMaterial value) { }

	public override void set_Name(string value) { }

	[CompilerGenerated]
	public void set_UserData(object value) { }

}

