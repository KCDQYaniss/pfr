namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class DisableContextMenuAttribute : Attribute
{
	public bool DisableForMember; //Field offset: 0x10
	public bool DisableForCollectionElements; //Field offset: 0x11

	public DisableContextMenuAttribute(bool disableForMember = true, bool disableCollectionElements = false) { }

}

