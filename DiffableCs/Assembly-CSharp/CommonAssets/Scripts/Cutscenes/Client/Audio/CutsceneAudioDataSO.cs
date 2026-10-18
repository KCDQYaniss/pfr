namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

[CreateAssetMenu(menuName = "Scriptable objects/Audio/Cutscene Audio Data")]
public class CutsceneAudioDataSO : ScriptableObject
{
	public List audioTrackConfigs; //Field offset: 0x18

	public CutsceneAudioDataSO() { }

}

