namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = False)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
[HideInTables]
[IncludeMyAttributes]
public class OnInspectorInitAttribute : ShowInInspectorAttribute
{
	public string Action; //Field offset: 0x10

	public OnInspectorInitAttribute() { }

	public OnInspectorInitAttribute(string action) { }

}

