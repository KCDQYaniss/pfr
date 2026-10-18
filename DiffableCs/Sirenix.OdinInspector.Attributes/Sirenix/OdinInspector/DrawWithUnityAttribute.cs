namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767))]
[Conditional("UNITY_EDITOR")]
public class DrawWithUnityAttribute : Attribute
{
	public bool PreferImGUI; //Field offset: 0x10

	public DrawWithUnityAttribute() { }

}

