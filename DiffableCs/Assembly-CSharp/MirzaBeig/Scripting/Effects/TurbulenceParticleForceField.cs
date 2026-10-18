namespace MirzaBeig.Scripting.Effects;

[AddComponentMenu("Effects/Particle Force Fields/Turbulence Particle Force Field")]
public class TurbulenceParticleForceField : ParticleForceField
{
	internal enum NoiseType
	{
		PseudoPerlin = 0,
		Perlin = 1,
		Simplex = 2,
		OctavePerlin = 3,
		OctaveSimplex = 4,
	}

	[Header("ForceField Controls")]
	[Tooltip("Noise texture mutation speed.")]
	public float scrollSpeed; //Field offset: 0xC0
	[Range(0, 8)]
	[Tooltip("Noise texture detail amplifier.")]
	public float frequency; //Field offset: 0xC4
	public NoiseType noiseType; //Field offset: 0xC8
	[Header("Octave Variant-Only Controls")]
	[Range(1, 8)]
	[Tooltip("Overlapping noise iterations. 1 = no additional iterations.")]
	public int octaves; //Field offset: 0xCC
	[Range(0, 4)]
	[Tooltip("Frequency scale per-octave. Can be used to change the overlap every iteration.")]
	public float octaveMultiplier; //Field offset: 0xD0
	[Range(0, 1)]
	[Tooltip("Amplitude scale per-octave. Can be used to change the overlap every iteration.")]
	public float octaveScale; //Field offset: 0xD4
	private float time; //Field offset: 0xD8
	private float randomX; //Field offset: 0xDC
	private float randomY; //Field offset: 0xE0
	private float randomZ; //Field offset: 0xE4
	private float offsetX; //Field offset: 0xE8
	private float offsetY; //Field offset: 0xEC
	private float offsetZ; //Field offset: 0xF0

	public TurbulenceParticleForceField() { }

	protected virtual void Awake() { }

	protected virtual Vector3 GetForce() { }

	protected virtual void LateUpdate() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

