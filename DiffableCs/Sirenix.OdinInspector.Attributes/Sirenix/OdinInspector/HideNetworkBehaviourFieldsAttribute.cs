namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class HideNetworkBehaviourFieldsAttribute : Attribute
{

	public HideNetworkBehaviourFieldsAttribute() { }

}

