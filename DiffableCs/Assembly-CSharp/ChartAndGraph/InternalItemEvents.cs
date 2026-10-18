namespace ChartAndGraph;

internal interface InternalItemEvents
{

	public IInternalUse Parent
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public object UserData
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IInternalUse get_Parent() { }

	public object get_UserData() { }

	public void set_Parent(IInternalUse value) { }

	public void set_UserData(object value) { }

}

