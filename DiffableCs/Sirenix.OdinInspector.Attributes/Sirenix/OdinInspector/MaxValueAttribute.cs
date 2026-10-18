namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class MaxValueAttribute : Attribute
{
	public double MaxValue; //Field offset: 0x10
	public string Expression; //Field offset: 0x18

	public MaxValueAttribute(double maxValue) { }

	public MaxValueAttribute(string expression) { }

}

