namespace EFT.Animations;

public class Spring
{
	internal enum VecComponent
	{
		X = 0,
		Y = 1,
		Z = 2,
	}

	public Vector3 Zero; //Field offset: 0x10
	public float InputIntensity; //Field offset: 0x1C
	public float ReturnSpeed; //Field offset: 0x20
	public float Damping; //Field offset: 0x24
	public Vector3 Min; //Field offset: 0x28
	public Vector3 Max; //Field offset: 0x34
	public float AccelerationMax; //Field offset: 0x40
	private AnimationCurve _curveLimitX; //Field offset: 0x48
	private AnimationCurve _curveLimitY; //Field offset: 0x50
	private AnimationCurve _curveLimitZ; //Field offset: 0x58
	protected float CurveTime; //Field offset: 0x60
	public bool Refrash; //Field offset: 0x64
	public float Softness; //Field offset: 0x68
	public VecComponent X; //Field offset: 0x6C
	public VecComponent Y; //Field offset: 0x70
	public VecComponent Z; //Field offset: 0x74
	public Vector3 Velocity; //Field offset: 0x78
	public Vector3 Current; //Field offset: 0x84
	protected Vector3 ForceAccumulator; //Field offset: 0x90
	protected Vector3 ForceAccumulatorLimitless; //Field offset: 0x9C
	public bool _update; //Field offset: 0xA8

	public Spring() { }

	public void AddAcceleration(int comp, float val) { }

	public void AddAcceleration(Vector3 acceleration) { }

	public void AddAccelerationLimitless(int comp, float val) { }

	public void AddAccelerationLimitless(Vector3 acceleration) { }

	public void AddZero() { }

	public override void FixedUpdate(float dt, int nFixedFrames = 1) { }

	public Vector3 Get() { }

	private static AnimationCurve GetCurve(float min, float max, float softness = 1) { }

	public Vector3 GetRelative() { }

	public Vector3 GetWithRedirection() { }

	public void Reset() { }

	private Vector3 SoftLimit(Vector3 vec) { }

}

