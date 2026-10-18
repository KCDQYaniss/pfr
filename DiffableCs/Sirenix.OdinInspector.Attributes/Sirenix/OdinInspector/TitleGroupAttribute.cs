namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class TitleGroupAttribute : PropertyGroupAttribute
{
	public string Subtitle; //Field offset: 0x38
	public TitleAlignments Alignment; //Field offset: 0x40
	public bool HorizontalLine; //Field offset: 0x44
	public bool BoldTitle; //Field offset: 0x45
	public bool Indent; //Field offset: 0x46

	public TitleGroupAttribute(string title, string subtitle = null, TitleAlignments alignment = 0, bool horizontalLine = true, bool boldTitle = true, bool indent = false, float order = 0) { }

	protected virtual void CombineValuesWith(PropertyGroupAttribute other) { }

}

