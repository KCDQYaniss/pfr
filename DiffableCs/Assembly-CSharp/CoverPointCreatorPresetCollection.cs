//Type is in global namespace

[CreateAssetMenu(fileName = "CoverPointCreatorPresetCollection", menuName = "Scriptable objects/AI/CoverPointCreator Preset Collection")]
public class CoverPointCreatorPresetCollection : ScriptableObject
{
	[SerializeField]
	private List _presets; //Field offset: 0x18

	public List Presets
	{
		 get { } //Length: 5
	}

	public CoverPointCreatorPresetCollection() { }

	public void DrawPresetsInspector() { }

	public List get_Presets() { }

	public static CoverPointCreatorPreset GetDefault() { }

	public CoverPointCreatorPreset GetPresetByName(string name) { }

}

