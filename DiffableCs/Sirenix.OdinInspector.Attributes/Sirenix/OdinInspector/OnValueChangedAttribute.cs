namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class OnValueChangedAttribute : Attribute
{
	public string Action; //Field offset: 0x10
	public bool IncludeChildren; //Field offset: 0x18
	public bool InvokeOnUndoRedo; //Field offset: 0x19
	public bool InvokeOnInitialize; //Field offset: 0x1A

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Action member instead.", False)]
	public string MethodName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public OnValueChangedAttribute(string action, bool includeChildren = false) { }

	public string get_MethodName() { }

	public void set_MethodName(string value) { }

}

