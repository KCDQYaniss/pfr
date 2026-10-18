namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class FilePathAttribute : Attribute
{
	public bool AbsolutePath; //Field offset: 0x10
	public string Extensions; //Field offset: 0x18
	public string ParentFolder; //Field offset: 0x20
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use RequireExistingPath instead.", True)]
	public bool RequireValidPath; //Field offset: 0x28
	public bool RequireExistingPath; //Field offset: 0x29
	public bool UseBackslashes; //Field offset: 0x2A
	public bool IncludeFileExtension; //Field offset: 0x2B
	[CompilerGenerated]
	private bool <ReadOnly>k__BackingField; //Field offset: 0x2C

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Add a ReadOnly attribute to the property instead.", True)]
	public bool ReadOnly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FilePathAttribute() { }

	[CompilerGenerated]
	public bool get_ReadOnly() { }

	[CompilerGenerated]
	public void set_ReadOnly(bool value) { }

}

