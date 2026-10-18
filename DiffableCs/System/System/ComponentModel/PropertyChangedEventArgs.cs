namespace System.ComponentModel;

public class PropertyChangedEventArgs : EventArgs
{
	private readonly string _propertyName; //Field offset: 0x10

	public override string PropertyName
	{
		 get { } //Length: 5
	}

	public PropertyChangedEventArgs(string propertyName) { }

	public override string get_PropertyName() { }

}

