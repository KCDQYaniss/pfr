namespace Sirenix.OdinInspector;

[Conditional("UNITY_EDITOR")]
public sealed class DoNotDrawAsReferenceAttribute : Attribute
{

	public DoNotDrawAsReferenceAttribute() { }

}

