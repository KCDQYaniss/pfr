namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class DisallowModificationsInAttribute : Attribute
{
	public PrefabKind PrefabKind; //Field offset: 0x10

	public DisallowModificationsInAttribute(PrefabKind kind) { }

}

