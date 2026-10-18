namespace EFT.Interactive;

[ExecuteInEditMode]
[ScriptOrder(10000)]
public class DoorAmbuent : MonoBehaviour
{
	private static readonly int _doorPoses; //Field offset: 0x0
	private static readonly int _openingVals; //Field offset: 0x4
	public AnalyticSource Source; //Field offset: 0x20
	public Transform DoorTransform; //Field offset: 0x28
	public Door DoorScript; //Field offset: 0x30
	public float Angle; //Field offset: 0x38
	public bool InvertDoorPosition; //Field offset: 0x3C
	public bool InvertDoorRotation; //Field offset: 0x3D
	public bool Rotate180; //Field offset: 0x3E
	public float DoorShift; //Field offset: 0x40
	public float MinTurningOffAngle; //Field offset: 0x44
	public float MinDeltaAngle; //Field offset: 0x48
	private float _lastAngle; //Field offset: 0x4C
	private bool _doorTransformExists; //Field offset: 0x50
	private Quaternion _localRotation; //Field offset: 0x54
	private float _lastDoorShift; //Field offset: 0x64

	private static DoorAmbuent() { }

	public DoorAmbuent() { }

	private void Awake() { }

	private static Vector3 GetAxis(EDoorAxis doorAxis) { }

	private void LateUpdate() { }

	public void PlacePerfect() { }

}

