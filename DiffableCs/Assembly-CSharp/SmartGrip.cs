//Type is in global namespace

public class SmartGrip : GripPose
{
	public Quaternion _initial; //Field offset: 0x48
	public Transform Targets; //Field offset: 0x58
	public Transform Pivot; //Field offset: 0x60
	public bool IkEnabled; //Field offset: 0x68
	private LimbIK[] _fingers; //Field offset: 0x70
	public Transform DEBUG_TARGET; //Field offset: 0x78
	public float Weight; //Field offset: 0x80

	public SmartGrip() { }

	public virtual void Awake() { }

	public virtual void CacheAndDestroy() { }

	public void EnableIK() { }

	public void LookAt(Vector3 target, bool debug = false) { }

	public void Reset() { }

}

