namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class CustomContextMenuAttribute : Attribute
{
	public string MenuItem; //Field offset: 0x10
	public string Action; //Field offset: 0x18

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Action member instead.", False)]
	public string MethodName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public CustomContextMenuAttribute(string menuItem, string action) { }

	public string get_MethodName() { }

	public void set_MethodName(string value) { }

}

