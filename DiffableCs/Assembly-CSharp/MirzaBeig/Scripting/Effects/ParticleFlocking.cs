namespace MirzaBeig.Scripting.Effects;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleFlocking : MonoBehaviour
{
	internal struct Voxel
	{
		public Bounds bounds; //Field offset: 0x0
		public int[] particles; //Field offset: 0x18
		public int particleCount; //Field offset: 0x20

	}

	[Header("N^2 Mode Settings")]
	public float maxDistance; //Field offset: 0x20
	[Header("Forces")]
	public float cohesion; //Field offset: 0x24
	public float separation; //Field offset: 0x28
	[Header("Voxel Mode Settings")]
	public bool useVoxels; //Field offset: 0x2C
	public bool voxelLocalCenterFromBounds; //Field offset: 0x2D
	public float voxelVolume; //Field offset: 0x30
	public int voxelsPerAxis; //Field offset: 0x34
	private int previousVoxelsPerAxisValue; //Field offset: 0x38
	private Voxel[] voxels; //Field offset: 0x40
	private ParticleSystem particleSystem; //Field offset: 0x48
	private Particle[] particles; //Field offset: 0x50
	private Vector3[] particlePositions; //Field offset: 0x58
	private MainModule particleSystemMainModule; //Field offset: 0x60
	[Header("General Performance Settings")]
	[Range(0, 1)]
	public float delay; //Field offset: 0x68
	private float timer; //Field offset: 0x6C
	public bool alwaysUpdate; //Field offset: 0x70
	private bool visible; //Field offset: 0x71

	public ParticleFlocking() { }

	private void buildVoxelGrid() { }

	private void LateUpdate() { }

	private void OnBecameInvisible() { }

	private void OnBecameVisible() { }

	private void OnDrawGizmosSelected() { }

	private void Start() { }

}

