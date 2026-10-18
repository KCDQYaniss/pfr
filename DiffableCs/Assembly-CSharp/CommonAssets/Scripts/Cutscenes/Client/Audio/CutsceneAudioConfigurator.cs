namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

public class CutsceneAudioConfigurator : IDisposable
{
	private readonly GameObject _audioRootGo; //Field offset: 0x10
	private readonly List _createdAudioSources; //Field offset: 0x18
	private readonly List _preloadedClips; //Field offset: 0x20

	public CutsceneAudioConfigurator(Transform root) { }

	public void Clear() { }

	public void Configure(TimelineAsset timelineAsset, CutsceneAudioDataSO audioData, PlayableDirector director) { }

	private AudioSource CreateAudioSource(CutsceneAudioTrackConfig config) { }

	public override void Dispose() { }

	private void PreloadAllAudioClips(TimelineAsset timelineAsset) { }

	private void UnloadAllAudioClips() { }

	private void ValidateAndAddClip(AudioClip clip) { }

}

