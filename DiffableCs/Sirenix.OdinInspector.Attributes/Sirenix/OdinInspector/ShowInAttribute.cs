namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
public class ShowInAttribute : Attribute
{
	public PrefabKind PrefabKind; //Field offset: 0x10

	public ShowInAttribute(PrefabKind prefabKind) { }

}

