namespace EFT;

[CreateAssetMenu(menuName = "Scriptable objects/HintDecalsConfig", fileName = "HintDecalsConfig")]
public class HintDecalsConfig : ScriptableObject
{
	private sealed class DecalMappingEntries : UnitySerializedDictionary
	{

		public DecalMappingEntries() { }

	}

	private sealed class DecalTypeMappingEntries : UnitySerializedDictionary
	{

		public DecalTypeMappingEntries() { }

	}

	private const string PATH = "HintDecalsConfig"; //Field offset: 0x0
	[SerializeField]
	private DecalTypeMappingEntries _decalMappings; //Field offset: 0x18

	public HintDecalsConfig() { }

	public static HintDecalsConfig Load() { }

	public bool TryGetEntry(EHintDecalsType decalsType, char key, out DecalMappingEntry mappingEntry) { }

}

