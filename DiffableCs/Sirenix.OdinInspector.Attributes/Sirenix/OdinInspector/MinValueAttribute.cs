namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MinValueAttribute : Attribute
{
	public double MinValue; //Field offset: 0x10
	public string Expression; //Field offset: 0x18

	public MinValueAttribute(double minValue) { }

	public MinValueAttribute(string expression) { }

}

