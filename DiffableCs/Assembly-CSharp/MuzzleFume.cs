//Type is in global namespace

public class MuzzleFume : MuzzleEffect
{
	public float StartPos; //Field offset: 0x20
	public float EmitterRadius; //Field offset: 0x24
	public float ConusSize; //Field offset: 0x28
	public AnimationCurve Sizes; //Field offset: 0x30
	public AnimationCurve Speeds; //Field offset: 0x38
	public AnimationCurve LifeTimes; //Field offset: 0x40
	public float SizesRnd; //Field offset: 0x48
	public float Size; //Field offset: 0x4C
	public float Speed; //Field offset: 0x50
	public float LifeTime; //Field offset: 0x54
	public Gradient Color; //Field offset: 0x58
	public int CountMin; //Field offset: 0x60
	public int CountRange; //Field offset: 0x64
	private Vector3 _lastPosition; //Field offset: 0x68
	private Transform _selfTransform; //Field offset: 0x78

	public MuzzleFume() { }

	private void Awake() { }

	public void Emit(IFumeEmitter emitter) { }

	public void UpdateValues() { }

}

