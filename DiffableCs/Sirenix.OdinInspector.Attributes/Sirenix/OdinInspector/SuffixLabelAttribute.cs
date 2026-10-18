namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = False)]
[Conditional("UNITY_EDITOR")]
public sealed class SuffixLabelAttribute : Attribute
{
	public string Label; //Field offset: 0x10
	public bool Overlay; //Field offset: 0x18
	public string IconColor; //Field offset: 0x20
	[CompilerGenerated]
	private bool <HasDefinedIcon>k__BackingField; //Field offset: 0x28
	private SdfIconType icon; //Field offset: 0x2C

	public private bool HasDefinedIcon
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SdfIconType Icon
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public SuffixLabelAttribute(string label, bool overlay = false) { }

	public SuffixLabelAttribute(string label, SdfIconType icon, bool overlay = false) { }

	public SuffixLabelAttribute(SdfIconType icon) { }

	[CompilerGenerated]
	public bool get_HasDefinedIcon() { }

	public SdfIconType get_Icon() { }

	[CompilerGenerated]
	private void set_HasDefinedIcon(bool value) { }

	public void set_Icon(SdfIconType value) { }

}

