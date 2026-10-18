//Type is in global namespace

public class SourceOccluder : MonoBehaviour
{
	private struct SourceOcclusionEntry
	{
		public BetterSource Wrapper; //Field offset: 0x0
		public int ContainerId; //Field offset: 0x8
		public bool WasCulled; //Field offset: 0xC

	}

	[SerializeField]
	private AudioMixerGroup _customOutputGroup; //Field offset: 0x20
	[SerializeField]
	private AudioSource[] _sources; //Field offset: 0x28
	[SerializeField]
	private bool _includeInAudioCulling; //Field offset: 0x30
	[SerializeField]
	private AudioSourceGroupType _groupType; //Field offset: 0x34
	[SerializeField]
	private EOcclusionTest _occlusionTest; //Field offset: 0x38
	[SerializeField]
	private bool _enabledLowPassFilter; //Field offset: 0x3C
	[SerializeField]
	private bool _enabledHighPassFilter; //Field offset: 0x3D
	[SerializeField]
	private bool _allowSourceVolumeUpdate; //Field offset: 0x3E
	[SerializeField]
	private bool _enabledReverb; //Field offset: 0x3F
	private SourceOcclusionEntry[] _entries; //Field offset: 0x40
	private SpatialAudioSystem _spatialSystem; //Field offset: 0x48
	private bool _initialized; //Field offset: 0x50
	private Action _unsubscribeOnDestroy; //Field offset: 0x58

	public SourceOccluder() { }

	private void Awake() { }

	public void CollectSources() { }

	private void CreateSourceWrappers() { }

	private void Init() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void SetupSources() { }

	private void SpatialAudioSystemInitializedHandler(SpatialAudioSystemInitializedEvent initEvent) { }

	private void Start() { }

	private void SyncOcclusionContainersWithCulling(bool initial) { }

}

