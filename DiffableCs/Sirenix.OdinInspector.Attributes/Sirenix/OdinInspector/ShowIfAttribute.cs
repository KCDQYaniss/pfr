namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class ShowIfAttribute : Attribute
{
	public string Condition; //Field offset: 0x10
	public object Value; //Field offset: 0x18
	public bool Animate; //Field offset: 0x20

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Condition member instead.", False)]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public ShowIfAttribute(string condition, bool animate = true) { }

	public ShowIfAttribute(string condition, object optionalValue, bool animate = true) { }

	public string get_MemberName() { }

	public void set_MemberName(string value) { }

}

