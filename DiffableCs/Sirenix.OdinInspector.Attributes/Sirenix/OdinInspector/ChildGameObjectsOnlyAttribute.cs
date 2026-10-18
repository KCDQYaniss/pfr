namespace Sirenix.OdinInspector;

[Conditional("UNITY_EDITOR")]
public class ChildGameObjectsOnlyAttribute : Attribute
{
	public bool IncludeSelf; //Field offset: 0x10
	public bool IncludeInactive; //Field offset: 0x11

	public ChildGameObjectsOnlyAttribute() { }

}

