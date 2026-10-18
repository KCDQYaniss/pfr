namespace Sirenix.OdinInspector;

[Conditional("UNITY_EDITOR")]
public sealed class DictionaryDrawerSettings : Attribute
{
	public string KeyLabel; //Field offset: 0x10
	public string ValueLabel; //Field offset: 0x18
	public DictionaryDisplayOptions DisplayMode; //Field offset: 0x20
	public bool IsReadOnly; //Field offset: 0x24
	public float KeyColumnWidth; //Field offset: 0x28

	public DictionaryDrawerSettings() { }

}

