namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class FolderPathAttribute : Attribute
{
	public bool AbsolutePath; //Field offset: 0x10
	public string ParentFolder; //Field offset: 0x18
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use RequireExistingPath instead.", True)]
	public bool RequireValidPath; //Field offset: 0x20
	public bool RequireExistingPath; //Field offset: 0x21
	public bool UseBackslashes; //Field offset: 0x22

	public FolderPathAttribute() { }

}

