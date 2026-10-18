namespace Audio.AmbientSubsystem;

[CreateAssetMenu(fileName = "ReverbPresets", menuName = "Audio/Reverb Presets", order = 1)]
public class ReverbPresets : ScriptableObject
{
	public string[] presetNames; //Field offset: 0x18

	public ReverbPresets() { }

}

