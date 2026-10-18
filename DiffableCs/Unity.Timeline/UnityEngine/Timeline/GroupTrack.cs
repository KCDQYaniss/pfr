namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[SupportsChildTracks((Type) null, 2147483647)]
[TrackClipType(typeof(TrackAsset))]
public class GroupTrack : TrackAsset
{

	public virtual IEnumerable outputs
	{
		 get { } //Length: 83
	}

	public GroupTrack() { }

	internal virtual bool CanCompileClips() { }

	public virtual IEnumerable get_outputs() { }

}

