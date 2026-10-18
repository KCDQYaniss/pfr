//Type is in global namespace

public class HeatEmitter : MonoBehaviour
{
	public Vector3 Bounds; //Field offset: 0x20
	public Vector3 Center; //Field offset: 0x2C
	[MinMaxVec2(0, 3, -1)]
	public Vector2 LifetimeDelta; //Field offset: 0x38
	[MinMaxVec2(0.01, 1, -1)]
	public Vector2 Size; //Field offset: 0x40
	public float IrradiationRate; //Field offset: 0x48
	public float HeatIncreasePerShot; //Field offset: 0x4C
	public AnimationCurve CountByHeat; //Field offset: 0x50
	public AnimationCurve LifeTimeByHeat; //Field offset: 0x58
	public float _heat; //Field offset: 0x60
	private float _lastEmitTime; //Field offset: 0x64
	private Vector3 prevPos; //Field offset: 0x68
	public float VelocityFactor; //Field offset: 0x74

	public HeatEmitter() { }

	public void Emit() { }

	public void LateUpdate() { }

	public void OnDrawGizmosSelected() { }

	public void OnShot() { }

	public void Start() { }

}

