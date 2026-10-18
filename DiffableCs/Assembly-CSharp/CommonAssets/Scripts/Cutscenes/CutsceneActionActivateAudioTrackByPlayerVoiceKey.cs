namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionActivateAudioTrackByPlayerVoiceKey : CutsceneBaseAction
{
	private struct PlayerVoiceKeyPair
	{
		public string voiceName; //Field offset: 0x0
		public string trackName; //Field offset: 0x8

	}

	[SerializeField]
	private TimelineAsset _timelineAsset; //Field offset: 0x40
	[SerializeField]
	private List _playerVoices; //Field offset: 0x48
	private readonly Dictionary _audioTracksCache; //Field offset: 0x50

	public CutsceneActionActivateAudioTrackByPlayerVoiceKey() { }

	private void CollectAudioTracks(Dictionary tracksCollection) { }

	public virtual void Deinit() { }

	private AudioClip GetAudioClipFromTrack(TrackAsset track) { }

	private void HandleTracks(string targetVoiceName) { }

	public virtual void Init() { }

}

