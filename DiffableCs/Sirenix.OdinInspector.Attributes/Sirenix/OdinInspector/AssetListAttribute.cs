namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False, Inherited = True)]
[Conditional("UNITY_EDITOR")]
public sealed class AssetListAttribute : Attribute
{
	public bool AutoPopulate; //Field offset: 0x10
	public string Tags; //Field offset: 0x18
	public string LayerNames; //Field offset: 0x20
	public string AssetNamePrefix; //Field offset: 0x28
	public string Path; //Field offset: 0x30
	public string CustomFilterMethod; //Field offset: 0x38

	public AssetListAttribute() { }

}

