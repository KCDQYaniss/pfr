namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
public class EnableGUIAttribute : Attribute
{

	public EnableGUIAttribute() { }

}

