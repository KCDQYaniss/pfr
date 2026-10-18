namespace RootMotion.FinalIK;

public abstract class RotationLimit : MonoBehaviour
{
	public Vector3 axis; //Field offset: 0x20
	[HideInInspector]
	public Quaternion defaultLocalRotation; //Field offset: 0x2C
	private bool initiated; //Field offset: 0x3C
	private bool applicationQuit; //Field offset: 0x3D

	public Vector3 crossAxis
	{
		 get { } //Length: 123
	}

	public Vector3 secondaryAxis
	{
		 get { } //Length: 21
	}

	protected RotationLimit() { }

	public bool Apply() { }

	private void Awake() { }

	public void Disable() { }

	public Vector3 get_crossAxis() { }

	public Vector3 get_secondaryAxis() { }

	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	private void LateUpdate() { }

	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	protected abstract Quaternion LimitRotation(Quaternion rotation) { }

	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	public void LogWarning(string message) { }

	public void SetDefaultLocalRotation() { }

}

