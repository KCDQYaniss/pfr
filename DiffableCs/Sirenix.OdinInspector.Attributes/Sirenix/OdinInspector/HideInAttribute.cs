namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
public class HideInAttribute : Attribute
{
	public PrefabKind PrefabKind; //Field offset: 0x10

	public HideInAttribute(PrefabKind prefabKind) { }

}

