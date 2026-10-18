//Type is in global namespace

public class LaserBeam : MonoBehaviour
{
	private static readonly int _distance; //Field offset: 0x0
	private static readonly int _intensity; //Field offset: 0x4
	private static readonly int _size; //Field offset: 0x8
	private static readonly int _maxDistId; //Field offset: 0xC
	private static readonly int _colorId; //Field offset: 0x10
	private static readonly int _factorId; //Field offset: 0x14
	public float RayStart; //Field offset: 0x20
	public float MaxDistance; //Field offset: 0x24
	public bool UsePointLight; //Field offset: 0x28
	public Material BeamMaterial; //Field offset: 0x30
	public Material PointMaterial; //Field offset: 0x38
	public LayerMask Mask; //Field offset: 0x40
	public float BeamSize; //Field offset: 0x44
	public float PointSizeClose; //Field offset: 0x48
	public float PointSizeFar; //Field offset: 0x4C
	public float SurfaceOffsetForLight; //Field offset: 0x50
	public float LightRange; //Field offset: 0x54
	public float LightIntensity; //Field offset: 0x58
	[SerializeField]
	private float IntensityFactor; //Field offset: 0x5C
	public Texture Cookie; //Field offset: 0x60
	public Vector2 AngleCloseFar; //Field offset: 0x68
	private bool _isYourPlayer; //Field offset: 0x70
	private Player _ownerPlayer; //Field offset: 0x78
	private Mesh _pointMesh; //Field offset: 0x80
	private Mesh _beamMesh; //Field offset: 0x88
	private Light _light; //Field offset: 0x90
	private MaterialPropertyBlock _beamBlock; //Field offset: 0x98
	private MaterialPropertyBlock _pointBlock; //Field offset: 0xA0

	private static LaserBeam() { }

	public LaserBeam() { }

	private void Awake() { }

	private void CreateLight() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	[ContextMenu("Reset")]
	private void Reset() { }

	private Player ResolveOwnerPlayer() { }

	public void SetOwner(bool isYourPlayer) { }

	private bool TryGetFovCompensation(out Transform handsHierarchy, out float scale) { }

}

