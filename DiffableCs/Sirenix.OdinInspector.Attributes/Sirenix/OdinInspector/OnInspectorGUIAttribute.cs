namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute
{
	public string Prepend; //Field offset: 0x10
	public string Append; //Field offset: 0x18
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Prepend member instead.", False)]
	public string PrependMethodName; //Field offset: 0x20
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Append member instead.", False)]
	public string AppendMethodName; //Field offset: 0x28

	public OnInspectorGUIAttribute() { }

	public OnInspectorGUIAttribute(string action, bool append = true) { }

	public OnInspectorGUIAttribute(string prepend, string append) { }

}

