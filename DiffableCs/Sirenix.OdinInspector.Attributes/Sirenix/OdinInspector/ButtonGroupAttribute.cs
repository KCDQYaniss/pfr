namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[IncludeMyAttributes]
[ShowInInspector]
public class ButtonGroupAttribute : PropertyGroupAttribute
{
	public int ButtonHeight; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HasDefinedButtonIconAlignment>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <HasDefinedButtonAlignment>k__BackingField; //Field offset: 0x3D
	[CompilerGenerated]
	private bool <HasDefinedStretch>k__BackingField; //Field offset: 0x3E
	private IconAlignment buttonIconAlignment; //Field offset: 0x40
	private int buttonAlignment; //Field offset: 0x44
	private bool stretch; //Field offset: 0x48

	public int ButtonAlignment
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public private bool HasDefinedButtonAlignment
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool HasDefinedButtonIconAlignment
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool HasDefinedStretch
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public IconAlignment IconAlignment
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool Stretch
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public ButtonGroupAttribute(string group = "_DefaultGroup", float order = 0) { }

	public int get_ButtonAlignment() { }

	[CompilerGenerated]
	public bool get_HasDefinedButtonAlignment() { }

	[CompilerGenerated]
	public bool get_HasDefinedButtonIconAlignment() { }

	[CompilerGenerated]
	public bool get_HasDefinedStretch() { }

	public IconAlignment get_IconAlignment() { }

	public bool get_Stretch() { }

	public void set_ButtonAlignment(int value) { }

	[CompilerGenerated]
	private void set_HasDefinedButtonAlignment(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedButtonIconAlignment(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedStretch(bool value) { }

	public void set_IconAlignment(IconAlignment value) { }

	public void set_Stretch(bool value) { }

}

