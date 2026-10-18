namespace Audio.SpatialSystem;

[DefaultMember("Item")]
public sealed class AudioSourceContainer : IEnumerable, IAudioOccluded
{
	private const float FAKE_BOUNDS_RADIUS = 0.15; //Field offset: 0x0
	public const int INVALID_ID = -1; //Field offset: 0x0
	private static readonly ISpatialAudioRoom _emptyRoom; //Field offset: 0x0
	private readonly List _sources; //Field offset: 0x10
	private readonly Dictionary _limitedSources; //Field offset: 0x18
	private Transform _parentTransform; //Field offset: 0x20
	private Vector3 _cachedPosition; //Field offset: 0x28
	private bool _initialized; //Field offset: 0x34
	private float _sqrMaxDistance; //Field offset: 0x38
	private Vector3 _positionOffset; //Field offset: 0x3C
	private float _maxQuality; //Field offset: 0x48
	private SourceBoundsCache _sourceBoundsCache; //Field offset: 0x4C
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private float <ObstructionEffect>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private float <PropagationEffect>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private float <OcclusionEffect>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private EOcclusionTest <OcclusionTest>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private ISpatialAudioRoom <CurrentAudioRoom>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private bool <IsLongTermSupported>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private float <MaxDistance>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private Action OnSourceAdded; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnSourceRemoved; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnSourcePlayed; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnContainerEmpty; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <UseQualityCompression>k__BackingField; //Field offset: 0xC0

	public event Action OnContainerEmpty
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSourceAdded
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSourcePlayed
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnSourceRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public int Count
	{
		 get { } //Length: 65
	}

	public ISpatialAudioRoom CurrentAudioRoom
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Vector3 CurrentPosition
	{
		 get { } //Length: 45
	}

	public private int ID
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsLongTermSupported
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsOutOfHearingRange
	{
		 get { } //Length: 258
	}

	public bool IsPlaying
	{
		 get { } //Length: 338
	}

	public bool IsValid
	{
		 get { } //Length: 100
	}

	public BetterSource Item
	{
		 get { } //Length: 112
	}

	public private float MaxDistance
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float MaxOcclusionQualityFactor
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public private override float ObstructionEffect
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private override float OcclusionEffect
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private EOcclusionTest OcclusionTest
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override float PropagationEffect
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public SourceBoundsCache SourceBoundsCache
	{
		 get { } //Length: 578
	}

	public float SqrMaxDistance
	{
		 get { } //Length: 6
	}

	public bool UseQualityCompression
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	private static AudioSourceContainer() { }

	public AudioSourceContainer() { }

	[CompilerGenerated]
	public void add_OnContainerEmpty(Action value) { }

	[CompilerGenerated]
	public void add_OnSourceAdded(Action value) { }

	[CompilerGenerated]
	public void add_OnSourcePlayed(Action value) { }

	[CompilerGenerated]
	public void add_OnSourceRemoved(Action value) { }

	public void AddSource(BetterSource source, bool limit = false) { }

	public void Clear() { }

	public void ClearOcclusionEffects() { }

	public int get_Count() { }

	[CompilerGenerated]
	public ISpatialAudioRoom get_CurrentAudioRoom() { }

	public Vector3 get_CurrentPosition() { }

	[CompilerGenerated]
	public int get_ID() { }

	[CompilerGenerated]
	public bool get_IsLongTermSupported() { }

	public bool get_IsOutOfHearingRange() { }

	public bool get_IsPlaying() { }

	public bool get_IsValid() { }

	public BetterSource get_Item(int i) { }

	[CompilerGenerated]
	public float get_MaxDistance() { }

	public float get_MaxOcclusionQualityFactor() { }

	[CompilerGenerated]
	public override float get_ObstructionEffect() { }

	[CompilerGenerated]
	public override float get_OcclusionEffect() { }

	[CompilerGenerated]
	public EOcclusionTest get_OcclusionTest() { }

	[CompilerGenerated]
	public override float get_PropagationEffect() { }

	public SourceBoundsCache get_SourceBoundsCache() { }

	public float get_SqrMaxDistance() { }

	[CompilerGenerated]
	public bool get_UseQualityCompression() { }

	public Vector3 GetCachedPosition() { }

	private Vector3 GetCurrentPosition() { }

	public IEnumerator GetEnumerator() { }

	public void Initialize(Transform parentTransform, EOcclusionTest test, int id, bool isLongTermSupported = false) { }

	public bool IsOutOfHearingRangeWithOffset(float offset = 0) { }

	public bool IsOutOfHearingRangeWithOffset(Vector3 targetPos, float offset = 5) { }

	public bool IsSourceAllowedLimit(int sourceInstanceID) { }

	[CompilerGenerated]
	public void remove_OnContainerEmpty(Action value) { }

	[CompilerGenerated]
	public void remove_OnSourceAdded(Action value) { }

	[CompilerGenerated]
	public void remove_OnSourcePlayed(Action value) { }

	[CompilerGenerated]
	public void remove_OnSourceRemoved(Action value) { }

	public void RemoveSource(BetterSource source) { }

	[CompilerGenerated]
	public void set_CurrentAudioRoom(ISpatialAudioRoom value) { }

	[CompilerGenerated]
	private void set_ID(int value) { }

	[CompilerGenerated]
	private void set_IsLongTermSupported(bool value) { }

	[CompilerGenerated]
	private void set_MaxDistance(float value) { }

	public void set_MaxOcclusionQualityFactor(float value) { }

	[CompilerGenerated]
	private void set_ObstructionEffect(float value) { }

	[CompilerGenerated]
	private void set_OcclusionEffect(float value) { }

	[CompilerGenerated]
	private void set_OcclusionTest(EOcclusionTest value) { }

	[CompilerGenerated]
	private void set_PropagationEffect(float value) { }

	[CompilerGenerated]
	public void set_UseQualityCompression(bool value) { }

	public void SetPositionOffset(Vector3 offset) { }

	private void StateChangedHandler(BetterSource betterSource, EPlayBackState state) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void UpdateCachedPosition() { }

	private void UpdateMaxDistance() { }

	public void UpdateOcclusionData(IAudioOccluded newOcclusionData) { }

}

