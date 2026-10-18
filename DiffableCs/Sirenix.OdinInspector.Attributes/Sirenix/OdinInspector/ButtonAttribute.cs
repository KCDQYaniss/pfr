namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = False)]
[Conditional("UNITY_EDITOR")]
public class ButtonAttribute : ShowInInspectorAttribute
{
	public string Name; //Field offset: 0x10
	public ButtonStyle Style; //Field offset: 0x18
	public bool Expanded; //Field offset: 0x1C
	public bool DisplayParameters; //Field offset: 0x1D
	public bool DirtyOnClick; //Field offset: 0x1E
	public SdfIconType Icon; //Field offset: 0x20
	[CompilerGenerated]
	private bool <HasDefinedButtonHeight>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <HasDefinedButtonIconAlignment>k__BackingField; //Field offset: 0x25
	[CompilerGenerated]
	private bool <HasDefinedButtonAlignment>k__BackingField; //Field offset: 0x26
	[CompilerGenerated]
	private bool <HasDefinedStretch>k__BackingField; //Field offset: 0x27
	private int buttonHeight; //Field offset: 0x28
	private bool drawResult; //Field offset: 0x2C
	private bool drawResultIsSet; //Field offset: 0x2D
	private bool stretch; //Field offset: 0x2E
	private IconAlignment buttonIconAlignment; //Field offset: 0x30
	private float buttonAlignment; //Field offset: 0x34

	public float ButtonAlignment
	{
		 get { } //Length: 6
		 set { } //Length: 10
	}

	public int ButtonHeight
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public bool DrawResult
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	public bool DrawResultIsSet
	{
		 get { } //Length: 5
	}

	public private bool HasDefinedButtonAlignment
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool HasDefinedButtonHeight
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

	public bool HasDefinedIcon
	{
		 get { } //Length: 8
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

	public ButtonAttribute(SdfIconType icon, string name) { }

	public ButtonAttribute(SdfIconType icon, IconAlignment iconAlignment) { }

	public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(string name, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(ButtonStyle parameterBtnStyle) { }

	public ButtonAttribute(string name, int buttonSize) { }

	public ButtonAttribute(string name, ButtonSizes buttonSize) { }

	public ButtonAttribute(string name) { }

	public ButtonAttribute(int buttonSize) { }

	public ButtonAttribute(ButtonSizes size) { }

	public ButtonAttribute() { }

	public ButtonAttribute(SdfIconType icon) { }

	public float get_ButtonAlignment() { }

	public int get_ButtonHeight() { }

	public bool get_DrawResult() { }

	public bool get_DrawResultIsSet() { }

	[CompilerGenerated]
	public bool get_HasDefinedButtonAlignment() { }

	[CompilerGenerated]
	public bool get_HasDefinedButtonHeight() { }

	[CompilerGenerated]
	public bool get_HasDefinedButtonIconAlignment() { }

	public bool get_HasDefinedIcon() { }

	[CompilerGenerated]
	public bool get_HasDefinedStretch() { }

	public IconAlignment get_IconAlignment() { }

	public bool get_Stretch() { }

	public void set_ButtonAlignment(float value) { }

	public void set_ButtonHeight(int value) { }

	public void set_DrawResult(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedButtonAlignment(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedButtonHeight(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedButtonIconAlignment(bool value) { }

	[CompilerGenerated]
	private void set_HasDefinedStretch(bool value) { }

	public void set_IconAlignment(IconAlignment value) { }

	public void set_Stretch(bool value) { }

}

