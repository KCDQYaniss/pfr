namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[HideInTables]
[IncludeMyAttributes]
public sealed class OnStateUpdateAttribute : Attribute
{
	public string Action; //Field offset: 0x10

	public OnStateUpdateAttribute(string action) { }

}

