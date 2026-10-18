namespace Koenigz.PerfectCulling.SamplingProviders;

[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(PerfectCullingBakingBehaviour))]
public class ExcludeFloatingSamplingProvider : SamplingProviderBase
{
	private const float TERRAIN_CHECK_HEIGHT = 400; //Field offset: 0x0
	[SerializeField]
	[Tooltip("Which layers will be used as colliders")]
	private LayerMask layerMask; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Box XZ half size\nShould equal to max jump distance in horizontal plane from infinite height")]
	private float areaSize; //Field offset: 0x2C
	[SerializeField]
	[Tooltip("Player height")]
	private float playerHeight; //Field offset: 0x30
	[SerializeField]
	private bool terrainVerticalCheck; //Field offset: 0x34
	[SerializeField]
	private float nearSurfaceCheckRadius; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	private Vector3 boxSize; //Field offset: 0x3C
	[SerializeField]
	private float _verticalVoidCheckDistance; //Field offset: 0x48
	private TerrainCollider[] _terrainColliders; //Field offset: 0x50

	public LayerMask CollisionMask
	{
		 get { } //Length: 4
	}

	public virtual string Name
	{
		 get { } //Length: 363
	}

	public bool UseTerrainVerticalCheck
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public ExcludeFloatingSamplingProvider() { }

	public LayerMask get_CollisionMask() { }

	public virtual string get_Name() { }

	public bool get_UseTerrainVerticalCheck() { }

	public virtual void InitializeSamplingProvider() { }

	public virtual bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos) { }

	private void OnValidate() { }

	public void set_UseTerrainVerticalCheck(bool value) { }

}

