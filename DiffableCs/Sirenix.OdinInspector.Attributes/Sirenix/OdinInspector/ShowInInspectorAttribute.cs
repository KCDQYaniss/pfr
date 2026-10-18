namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = False)]
[Conditional("UNITY_EDITOR")]
[MeansImplicitUse]
public class ShowInInspectorAttribute : Attribute
{

	public ShowInInspectorAttribute() { }

}

