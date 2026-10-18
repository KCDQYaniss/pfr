namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class WrapAttribute : Attribute
{
	public double Min; //Field offset: 0x10
	public double Max; //Field offset: 0x18

	public WrapAttribute(double min, double max) { }

}

