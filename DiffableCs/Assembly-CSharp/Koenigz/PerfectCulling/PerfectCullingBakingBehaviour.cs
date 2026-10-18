namespace Koenigz.PerfectCulling;

public abstract class PerfectCullingBakingBehaviour : MonoBehaviour, IBakingBehaviour
{
	private static IActiveSamplingProvider DefaultSamplingProvider; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsBakeActive>k__BackingField; //Field offset: 0x8
	public HashSet SamplingProviders; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	public PerfectCullingBakeGroup[] _bakeGroups; //Field offset: 0x28
	[SerializeField]
	public List _additionalOccluders; //Field offset: 0x30
	[CompilerGenerated]
	private readonly PerfectCullingBakeData <BakeData>k__BackingField; //Field offset: 0x38
	public int TotalVertexCount; //Field offset: 0x40

	public override List additionalOccluders
	{
		 get { } //Length: 76
		 set { } //Length: 82
	}

	public override PerfectCullingBakeData BakeData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override PerfectCullingBakeGroup[] bakeGroups
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public static bool IsBakeActive
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	private static PerfectCullingBakingBehaviour() { }

	protected PerfectCullingBakingBehaviour() { }

	public override void AddSamplingProvider(IActiveSamplingProvider samplingProvider) { }

	protected override void CullAdditionalOccluders(ref HashSet additionalOccluders) { }

	public override List get_additionalOccluders() { }

	[CompilerGenerated]
	public override PerfectCullingBakeData get_BakeData() { }

	public override PerfectCullingBakeGroup[] get_bakeGroups() { }

	[CompilerGenerated]
	public static bool get_IsBakeActive() { }

	public override int GetBakeHash() { }

	public override int GetIndexForWorldPos(Vector3 worldPos, out bool isOutOfBounds) { }

	public override void GetIndicesForIndex(int index, List indices) { }

	public override void GetIndicesForWorldPos(Vector3 worldPos, List indices) { }

	public override List GetSamplingPositions(Space space = 1) { }

	public override Vector3 GetWorldPositionForIndex(int index) { }

	public void InitializeAllSamplingProviders() { }

	public override void InitializeBake() { }

	public override void PostBake() { }

	public override void PostProcessBakeData(PerfectCullingBakeData data) { }

	public override bool PreBake() { }

	public override void RemoveSamplingProvider(IActiveSamplingProvider samplingProvider) { }

	public bool SamplingProvidersIsPositionActive(Vector3 pos) { }

	public override void set_additionalOccluders(List value) { }

	public override void set_bakeGroups(PerfectCullingBakeGroup[] value) { }

	[CompilerGenerated]
	public static void set_IsBakeActive(bool value) { }

	public override void SetBakeData(PerfectCullingBakeData bakeData) { }

	public override void Start() { }

	public void ToggleAllRenderers(bool state, bool forceNullCheck = false) { }

}

