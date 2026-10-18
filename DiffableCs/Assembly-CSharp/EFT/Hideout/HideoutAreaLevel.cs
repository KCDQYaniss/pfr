namespace EFT.Hideout;

public sealed class HideoutAreaLevel : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private struct <CreateEffect>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutAreaLevel <>4__this; //Field offset: 0x20
		public Transform arg; //Field offset: 0x28
		private ParticleSystem <effect>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class GarbageController
	{
		[SerializeField]
		private Transform _floorGarbage; //Field offset: 0x10
		[SerializeField]
		private Transform _wallGarbage; //Field offset: 0x18

		public GarbageController() { }

		public void Init(Transform parent) { }

		public void UpdateGarbageVisibility(Dictionary installedItems) { }

	}

	[SerializeField]
	private Dictionary _lightingLevels; //Field offset: 0x60
	[SerializeField]
	private AreaLevelAudio _audioAmbiance; //Field offset: 0x68
	[SerializeField]
	private ParticleSystem _constructionParticlesTemplate; //Field offset: 0x70
	[SerializeField]
	private GameObject _immediateEnable; //Field offset: 0x78
	[SerializeField]
	private Transform _highlightTransform; //Field offset: 0x80
	[SerializeField]
	private Transform[] _producedObjectsSpawnPoints; //Field offset: 0x88
	[SerializeField]
	private GarbageController _garbageController; //Field offset: 0x90
	[CompilerGenerated]
	private Dictionary <StashObjectsSpawnPoints>k__BackingField; //Field offset: 0x98
	private Stage _stage; //Field offset: 0xA0
	private List _producedObjects; //Field offset: 0xA8
	private IReadOnlyCollection _availableLightingLevels; //Field offset: 0xB0
	private EAreaType _areaType; //Field offset: 0xB8

	public AreaLevelAudio AudioAmbiance
	{
		 get { } //Length: 5
	}

	public bool CanSetProducedItemsOnPlace
	{
		 get { } //Length: 21
	}

	public Transform HighlightTransform
	{
		 get { } //Length: 361
		 set { } //Length: 82
	}

	public Dictionary LightingLevels
	{
		 get { } //Length: 5
	}

	public RelatedSounds Sounds
	{
		 get { } //Length: 30
	}

	[SerializeField]
	public private Dictionary StashObjectsSpawnPoints
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HideoutAreaLevel() { }

	[AsyncStateMachine(typeof(<CreateEffect>d__29))]
	private Task CreateEffect(Transform arg) { }

	public void Disable() { }

	public void Enable(bool immediate) { }

	public AreaLevelAudio get_AudioAmbiance() { }

	public bool get_CanSetProducedItemsOnPlace() { }

	public Transform get_HighlightTransform() { }

	public Dictionary get_LightingLevels() { }

	public RelatedSounds get_Sounds() { }

	[CompilerGenerated]
	public Dictionary get_StashObjectsSpawnPoints() { }

	public void Init(Stage stage, EAreaType areaType) { }

	public void set_HighlightTransform(Transform value) { }

	[CompilerGenerated]
	private void set_StashObjectsSpawnPoints(Dictionary value) { }

	public void SetAvailableLightingLevels(IReadOnlyCollection availableLevels) { }

	public void SetItemsOnPlace(IEnumerable dynamicObjects) { }

	public void SetLightLevel(ELightingLevel level) { }

	public void UpdateGarbage(Dictionary installedItems) { }

}

