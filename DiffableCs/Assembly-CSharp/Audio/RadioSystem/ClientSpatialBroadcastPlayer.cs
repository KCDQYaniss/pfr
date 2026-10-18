namespace Audio.RadioSystem;

public class ClientSpatialBroadcastPlayer : ClientBroadcastPlayer
{
	[Header("Spatial Settings")]
	[SerializeField]
	[Space]
	private bool _spatialize; //Field offset: 0x88
	[SerializeField]
	private float _volumetricRadius; //Field offset: 0x8C
	[SerializeField]
	private DirectivityPatternType _directivityPatternType; //Field offset: 0x90
	[Range(0, 1)]
	[SerializeField]
	private float _hrtfIntensity; //Field offset: 0x94
	private MetaXRAudioSource[] _metaXRAudioSource; //Field offset: 0x98
	private MetaXRAudioSourceExperimentalFeatures[] _features; //Field offset: 0xA0

	public ClientSpatialBroadcastPlayer() { }

	public virtual void ChangeAudibleState(EAudibleState state) { }

	public virtual void Initialize() { }

	protected virtual void SetupSource(AudioSource source) { }

	private void SetupSpatialComponents() { }

}

