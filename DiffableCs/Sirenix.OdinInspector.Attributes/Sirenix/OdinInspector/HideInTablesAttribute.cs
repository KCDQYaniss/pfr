namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False)]
[Conditional("UNITY_EDITOR")]
public class HideInTablesAttribute : Attribute
{

	public HideInTablesAttribute() { }

}

