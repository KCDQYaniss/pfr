namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class InlineButtonAttribute : Attribute
{
	public string Action; //Field offset: 0x10
	public string Label; //Field offset: 0x18
	public string ShowIf; //Field offset: 0x20
	public string ButtonColor; //Field offset: 0x28
	public string TextColor; //Field offset: 0x30
	public SdfIconType Icon; //Field offset: 0x38
	public IconAlignment IconAlignment; //Field offset: 0x3C

	[Obsolete("Use the Action member instead.", False)]
	public string MemberMethod
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public InlineButtonAttribute(string action, string label = null) { }

	public InlineButtonAttribute(string action, SdfIconType icon, string label = null) { }

	public string get_MemberMethod() { }

	public void set_MemberMethod(string value) { }

}

