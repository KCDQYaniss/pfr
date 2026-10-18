namespace Koenigz.PerfectCulling.EFT;

[RequireComponent(typeof(GuidComponent))]
public sealed class PerfectCullingSuperSamplingVolume : MonoBehaviour, IVolumeDataProvider, IResizableByHandle
{
	public static readonly Color GIZMO_VOLUME_COLOR; //Field offset: 0x0
	[SerializeField]
	private GuidReference _crossGroupReference; //Field offset: 0x20
	[SerializeField]
	private int _cellSize; //Field offset: 0x28
	[SerializeField]
	private Vector3 _volumeSize; //Field offset: 0x2C
	[SerializeField]
	private string _cachedGuid; //Field offset: 0x38

	public Vector3 BakeCellSize
	{
		 get { } //Length: 244
	}

	public int CellCount
	{
		 get { } //Length: 154
	}

	public int CellSize
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public PerfectCullingCrossSceneGroup CrossGroup
	{
		 get { } //Length: 91
	}

	public GuidReference CrossGroupReference
	{
		 get { } //Length: 5
	}

	public override Vector3 HandleSized
	{
		 get { } //Length: 81
		 set { } //Length: 310
	}

	public override Vector3 SizeOfVolume
	{
		 get { } //Length: 19
	}

	public Bounds VolumeBakeBounds
	{
		 get { } //Length: 274
		 set { } //Length: 284
	}

	public override string VolumeGuid
	{
		 get { } //Length: 5
	}

	public Vector3 VolumeSize
	{
		 get { } //Length: 19
	}

	private static PerfectCullingSuperSamplingVolume() { }

	public PerfectCullingSuperSamplingVolume() { }

	public static PerfectCullingSuperSamplingVolume Create(PerfectCullingCrossSceneVolume volume, PerfectCullingCrossSceneGroup group, int cellSizeType) { }

	public void FixVolumeSize() { }

	public Vector3 get_BakeCellSize() { }

	public int get_CellCount() { }

	public int get_CellSize() { }

	public PerfectCullingCrossSceneGroup get_CrossGroup() { }

	public GuidReference get_CrossGroupReference() { }

	public override Vector3 get_HandleSized() { }

	public override Vector3 get_SizeOfVolume() { }

	public Bounds get_VolumeBakeBounds() { }

	public override string get_VolumeGuid() { }

	public Vector3 get_VolumeSize() { }

	public override Vector3 GetSamplingPositionAt(int index, Vector3 cellSize, Space space = 1) { }

	private Vector3 GetSamplingPositionAt(int index, Vector3 gridSize, Vector3 cellSize, Space space = 1) { }

	public List GetSamplingPositions(Space space = 1) { }

	public override List GetSamplingProviders() { }

	public override IReadOnlyCollection GetUniqueBakeCellSizes() { }

	public void set_CellSize(int value) { }

	public override void set_HandleSized(Vector3 value) { }

	public void set_VolumeBakeBounds(Bounds value) { }

}

