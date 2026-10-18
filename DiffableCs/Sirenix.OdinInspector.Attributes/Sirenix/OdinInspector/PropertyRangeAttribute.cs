namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class PropertyRangeAttribute : Attribute
{
	public double Min; //Field offset: 0x10
	public double Max; //Field offset: 0x18
	public string MinGetter; //Field offset: 0x20
	public string MaxGetter; //Field offset: 0x28

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the MaxGetter member instead.", False)]
	public string MaxMember
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the MinGetter member instead.", False)]
	public string MinMember
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public PropertyRangeAttribute(double min, double max) { }

	public PropertyRangeAttribute(string minGetter, double max) { }

	public PropertyRangeAttribute(double min, string maxGetter) { }

	public PropertyRangeAttribute(string minGetter, string maxGetter) { }

	public string get_MaxMember() { }

	public string get_MinMember() { }

	public void set_MaxMember(string value) { }

	public void set_MinMember(string value) { }

}

