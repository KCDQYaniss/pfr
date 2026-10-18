//Type is in global namespace

[ExecuteInEditMode]
public class LocalDustParticles : MonoBehaviour
{
	public LocalDustParticlesParent PurticlesParent; //Field offset: 0x20
	public int Count; //Field offset: 0x28
	public Color ParticlesColor; //Field offset: 0x2C
	public float AlphaRandomness; //Field offset: 0x3C
	public float SizeRandomness; //Field offset: 0x40
	public float SideSpeed; //Field offset: 0x44
	private Matrix4x4 _lastMatrix; //Field offset: 0x48
	private int _lastCount; //Field offset: 0x88
	private float _lastSideSpeed; //Field offset: 0x8C
	private Color _lastParticlesColor; //Field offset: 0x90
	private float _lastAlphaRandomness; //Field offset: 0xA0
	private float _lastSizeRandomness; //Field offset: 0xA4

	public LocalDustParticles() { }

	private void OnDrawGizmosSelected() { }

	private void OnEnable() { }

}

