namespace System.Security;

[ComVisible(True)]
public sealed class NamedPermissionSet : PermissionSet
{
	private string name; //Field offset: 0x30
	private string description; //Field offset: 0x38

	public string Name
	{
		 get { } //Length: 76
		 set { } //Length: 290
	}

	internal NamedPermissionSet() { }

	public NamedPermissionSet(string name, PermissionState state) { }

	public NamedPermissionSet(NamedPermissionSet permSet) { }

	public NamedPermissionSet(string name) { }

	public virtual PermissionSet Copy() { }

	[ComVisible(False)]
	public virtual bool Equals(object obj) { }

	public string get_Name() { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	public void set_Name(string value) { }

	public virtual SecurityElement ToXml() { }

}

