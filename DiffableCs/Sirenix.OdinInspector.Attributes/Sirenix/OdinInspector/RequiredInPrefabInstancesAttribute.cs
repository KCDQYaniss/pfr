namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [RequiredIn(PrefabKind.PrefabInstance)] instead.", True)]
public sealed class RequiredInPrefabInstancesAttribute : Attribute
{
	public string ErrorMessage; //Field offset: 0x10
	public InfoMessageType MessageType; //Field offset: 0x18

	public RequiredInPrefabInstancesAttribute() { }

	public RequiredInPrefabInstancesAttribute(string errorMessage, InfoMessageType messageType) { }

	public RequiredInPrefabInstancesAttribute(string errorMessage) { }

	public RequiredInPrefabInstancesAttribute(InfoMessageType messageType) { }

}

