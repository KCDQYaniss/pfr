namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
public class ShowDrawerChainAttribute : Attribute
{

	public ShowDrawerChainAttribute() { }

}

