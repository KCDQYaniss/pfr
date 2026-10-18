namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class LabelTextAttribute : Attribute
{
	public string Text; //Field offset: 0x10
	public bool NicifyText; //Field offset: 0x18
	public SdfIconType Icon; //Field offset: 0x1C
	public string IconColor; //Field offset: 0x20

	public LabelTextAttribute(string text) { }

	public LabelTextAttribute(SdfIconType icon) { }

	public LabelTextAttribute(string text, bool nicifyText) { }

	public LabelTextAttribute(string text, SdfIconType icon) { }

	public LabelTextAttribute(string text, bool nicifyText, SdfIconType icon) { }

}

