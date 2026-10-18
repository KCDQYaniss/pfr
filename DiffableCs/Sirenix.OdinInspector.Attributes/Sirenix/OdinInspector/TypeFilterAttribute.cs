namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class TypeFilterAttribute : Attribute
{
	public string FilterGetter; //Field offset: 0x10
	public string DropdownTitle; //Field offset: 0x18
	public bool DrawValueNormally; //Field offset: 0x20

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the FilterGetter member instead.", False)]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public TypeFilterAttribute(string filterGetter) { }

	public string get_MemberName() { }

	public void set_MemberName(string value) { }

}

