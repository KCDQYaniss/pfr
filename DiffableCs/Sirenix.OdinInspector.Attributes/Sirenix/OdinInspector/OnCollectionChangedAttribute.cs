namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class OnCollectionChangedAttribute : Attribute
{
	public string Before; //Field offset: 0x10
	public string After; //Field offset: 0x18

	public OnCollectionChangedAttribute() { }

	public OnCollectionChangedAttribute(string after) { }

	public OnCollectionChangedAttribute(string before, string after) { }

}

