namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class RequiredAttribute : Attribute
{
	public string ErrorMessage; //Field offset: 0x10
	public InfoMessageType MessageType; //Field offset: 0x18

	public RequiredAttribute() { }

	public RequiredAttribute(string errorMessage, InfoMessageType messageType) { }

	public RequiredAttribute(string errorMessage) { }

	public RequiredAttribute(InfoMessageType messageType) { }

}

