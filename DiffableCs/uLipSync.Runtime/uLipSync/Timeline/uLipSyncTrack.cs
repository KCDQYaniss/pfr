namespace uLipSync.Timeline;

[TrackBindingType(typeof(uLipSyncTimelineEvent))]
[TrackClipType(typeof(uLipSyncClip))]
[TrackColor(0.2, 0.8, 0.3)]
public class uLipSyncTrack : TrackAsset
{

	public uLipSyncTrack() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	private void UpdateClipNames() { }

}

