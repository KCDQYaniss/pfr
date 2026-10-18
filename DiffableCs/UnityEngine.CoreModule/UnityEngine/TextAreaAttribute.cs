namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class TextAreaAttribute : PropertyAttribute
{
	public readonly int minLines; //Field offset: 0x18
	public readonly int maxLines; //Field offset: 0x1C

	public TextAreaAttribute() { }

	public TextAreaAttribute(int minLines, int maxLines) { }

}

