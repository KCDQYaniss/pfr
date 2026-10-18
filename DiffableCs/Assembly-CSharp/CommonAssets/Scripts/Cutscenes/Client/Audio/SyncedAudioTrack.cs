namespace CommonAssets.Scripts.Cutscenes.Client.Audio;

[TrackBindingType(typeof(AudioSource))]
[TrackClipType(typeof(SyncedAudioClip))]
[TrackColor(0.2, 0.8, 0.3)]
public class SyncedAudioTrack : TrackAsset
{

	public SyncedAudioTrack() { }

	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	protected virtual void OnCreateClip(TimelineClip clip) { }

}

