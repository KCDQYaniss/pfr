namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class DisableInAttribute : Attribute
{
	public PrefabKind PrefabKind; //Field offset: 0x10

	public DisableInAttribute(PrefabKind prefabKind) { }

}

