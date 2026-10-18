namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class ToggleLeftAttribute : Attribute
{

	public ToggleLeftAttribute() { }

}

