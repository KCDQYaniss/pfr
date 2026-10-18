namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public class DetailedInfoBoxAttribute : Attribute
{
	public string Message; //Field offset: 0x10
	public string Details; //Field offset: 0x18
	public InfoMessageType InfoMessageType; //Field offset: 0x20
	public string VisibleIf; //Field offset: 0x28

	public DetailedInfoBoxAttribute(string message, string details, InfoMessageType infoMessageType = 1, string visibleIf = null) { }

}

