namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionActivateAudioTrackBySeason : CutsceneBaseAction
{
	private struct SeasonTrackPair
	{
		public ESeasonStatus seasonStatus; //Field offset: 0x0
		public string trackName; //Field offset: 0x8

	}

	[SerializeField]
	private TimelineAsset _timelineAsset; //Field offset: 0x40
	[SerializeField]
	private List _seasonTracks; //Field offset: 0x48
	private readonly Dictionary _audioTracksCache; //Field offset: 0x50

	public CutsceneActionActivateAudioTrackBySeason() { }

	private void CollectAudioTracks() { }

	public virtual void Deinit() { }

	private AudioClip GetAudioClipFromTrack(TrackAsset track) { }

	private void HandleSeasonController() { }

	private void HandleTracks(ESeasonStatus targetSeason) { }

	public virtual void Init() { }

}

