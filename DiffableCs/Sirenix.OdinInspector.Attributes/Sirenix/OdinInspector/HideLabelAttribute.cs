namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
public class HideLabelAttribute : Attribute
{

	public HideLabelAttribute() { }

}

