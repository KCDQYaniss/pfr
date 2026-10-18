namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class InfoBoxAttribute : Attribute
{
	public string Message; //Field offset: 0x10
	public InfoMessageType InfoMessageType; //Field offset: 0x18
	public string VisibleIf; //Field offset: 0x20
	public bool GUIAlwaysEnabled; //Field offset: 0x28
	public string IconColor; //Field offset: 0x30
	[CompilerGenerated]
	private bool <HasDefinedIcon>k__BackingField; //Field offset: 0x38
	private SdfIconType icon; //Field offset: 0x3C

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

	public InfoBoxAttribute(string message, InfoMessageType infoMessageType = 1, string visibleIfMemberName = null) { }

	public InfoBoxAttribute(string message, string visibleIfMemberName) { }

	public InfoBoxAttribute(string message, SdfIconType icon, string visibleIfMemberName = null) { }

	[CompilerGenerated]
	public bool get_HasDefinedIcon() { }

	public SdfIconType get_Icon() { }

	[CompilerGenerated]
	private void set_HasDefinedIcon(bool value) { }

	public void set_Icon(SdfIconType value) { }

}

