namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public class GUIColorAttribute : Attribute
{
	public Color Color; //Field offset: 0x10
	public string GetColor; //Field offset: 0x20

	public GUIColorAttribute(float r, float g, float b, float a = 1) { }

	public GUIColorAttribute(string getColor) { }

}

