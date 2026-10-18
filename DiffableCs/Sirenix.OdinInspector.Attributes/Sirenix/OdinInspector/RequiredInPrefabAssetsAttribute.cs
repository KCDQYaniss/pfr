namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[EditorBrowsable(EditorBrowsableState::Never (1))]
[Obsolete("Use [RequiredIn(PrefabKind.PrefabAsset)] instead.", True)]
public sealed class RequiredInPrefabAssetsAttribute : Attribute
{
	public string ErrorMessage; //Field offset: 0x10
	public InfoMessageType MessageType; //Field offset: 0x18

	public RequiredInPrefabAssetsAttribute() { }

	public RequiredInPrefabAssetsAttribute(string errorMessage, InfoMessageType messageType) { }

	public RequiredInPrefabAssetsAttribute(string errorMessage) { }

	public RequiredInPrefabAssetsAttribute(InfoMessageType messageType) { }

}

