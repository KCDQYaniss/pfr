namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class TableColumnWidthAttribute : Attribute
{
	public int Width; //Field offset: 0x10
	public bool Resizable; //Field offset: 0x14

	public TableColumnWidthAttribute(int width, bool resizable = true) { }

}

