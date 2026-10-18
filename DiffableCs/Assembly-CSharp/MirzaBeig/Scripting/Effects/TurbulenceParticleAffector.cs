namespace MirzaBeig.Scripting.Effects;

public class TurbulenceParticleAffector : ParticleAffector
{
	internal enum NoiseType
	{
		PseudoPerlin = 0,
		Perlin = 1,
		Simplex = 2,
		OctavePerlin = 3,
		OctaveSimplex = 4,
	}

	[Header("Affector Controls")]
	public float speed; //Field offset: 0xC0
	[Range(0, 8)]
	public float frequency; //Field offset: 0xC4
	public NoiseType noiseType; //Field offset: 0xC8
	[Header("Octave Variant-Only Controls")]
	[Range(1, 8)]
	public int octaves; //Field offset: 0xCC
	[Range(0, 4)]
	public float lacunarity; //Field offset: 0xD0
	[Range(0, 1)]
	public float persistence; //Field offset: 0xD4
	private float time; //Field offset: 0xD8
	private float randomX; //Field offset: 0xDC
	private float randomY; //Field offset: 0xE0
	private float randomZ; //Field offset: 0xE4
	private float offsetX; //Field offset: 0xE8
	private float offsetY; //Field offset: 0xEC
	private float offsetZ; //Field offset: 0xF0

	public TurbulenceParticleAffector() { }

	protected virtual void Awake() { }

	protected virtual Vector3 GetForce() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

