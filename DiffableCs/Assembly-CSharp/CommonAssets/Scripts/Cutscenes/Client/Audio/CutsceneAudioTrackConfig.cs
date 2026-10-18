namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class CutsceneAudioTrackConfig
{
	public string trackName; //Field offset: 0x10
	public AudioMixerGroup mixerGroup; //Field offset: 0x18
	[Range(0, 1)]
	public float volume; //Field offset: 0x20

	public CutsceneAudioTrackConfig() { }

}

