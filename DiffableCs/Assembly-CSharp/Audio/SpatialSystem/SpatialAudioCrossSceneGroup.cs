namespace Audio.SpatialSystem;

[RequireComponent(typeof(GuidComponent))]
public sealed class SpatialAudioCrossSceneGroup : MonoBehaviour
{
	public static readonly List AllCrossGroups; //Field offset: 0x0
	[HideInInspector]
	public GuidReference crossSceneGroup; //Field offset: 0x20
	public List AudioRooms; //Field offset: 0x28
	public List AudioPortals; //Field offset: 0x30

	private static SpatialAudioCrossSceneGroup() { }

	public SpatialAudioCrossSceneGroup() { }

	public void Awake() { }

	private void Collect() { }

	public void OnDestroy() { }

	public void OnValidate() { }

}

