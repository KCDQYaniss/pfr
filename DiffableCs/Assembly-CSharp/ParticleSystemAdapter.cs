//Type is in global namespace

public class ParticleSystemAdapter : Emitter
{
	private static readonly int MAXRNDNUMBERS; //Field offset: 0x0
	public ParticleSystem ParticleSystemObject; //Field offset: 0x20
	public RundomRange Lifetime; //Field offset: 0x28
	public RundomRange Speed; //Field offset: 0x30
	public RundomRange Size; //Field offset: 0x38
	public bool RotationRandom; //Field offset: 0x40
	public float Rotation; //Field offset: 0x44
	public Color32 Color; //Field offset: 0x48
	private int _iterator; //Field offset: 0x4C
	private float[] _lifeTimes; //Field offset: 0x50
	private float[] _speeds; //Field offset: 0x58
	private float[] _sizes; //Field offset: 0x60
	private float[] _rotations; //Field offset: 0x68
	private uint[] _rotationSeeds; //Field offset: 0x70

	private static ParticleSystemAdapter() { }

	public ParticleSystemAdapter() { }

	private void Awake() { }

	public virtual void Emit(Vector3 pos, Vector3 vel) { }

	public void Emit(Vector3 pos, Vector3 vel, float sizeMult) { }

	private void FillValues() { }

}

