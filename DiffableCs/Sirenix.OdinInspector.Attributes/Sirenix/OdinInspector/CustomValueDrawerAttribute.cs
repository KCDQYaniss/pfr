namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class CustomValueDrawerAttribute : Attribute
{
	public string Action; //Field offset: 0x10

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Action member instead.", False)]
	public string MethodName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public CustomValueDrawerAttribute(string action) { }

	public string get_MethodName() { }

	public void set_MethodName(string value) { }

}

