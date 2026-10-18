namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class DisableInInlineEditorsAttribute : Attribute
{

	public DisableInInlineEditorsAttribute() { }

}

