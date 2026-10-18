namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[HideInMenu]
[TrackBindingType(typeof(GameObject))]
public class MarkerTrack : TrackAsset
{

	public virtual IEnumerable outputs
	{
		 get { } //Length: 719
	}

	public MarkerTrack() { }

	public virtual IEnumerable get_outputs() { }

}

