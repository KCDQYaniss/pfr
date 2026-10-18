namespace ChartAndGraph.DataSource;

public interface IDataItem
{

	public event Action NameChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public string Name
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_NameChanged(Action value) { }

	public void CancelNameChange() { }

	public string get_Name() { }

	[CompilerGenerated]
	public void remove_NameChanged(Action value) { }

	public void set_Name(string value) { }

}

