namespace EFT.Vehicle.Vehicles;

public class VehicleSuspensionSpring : MonoBehaviour
{
	public Rigidbody rb; //Field offset: 0x20
	public float restLenght; //Field offset: 0x28
	public float springTravel; //Field offset: 0x2C
	public float springStiffness; //Field offset: 0x30
	public float damperStiffness; //Field offset: 0x34
	private float minLenght; //Field offset: 0x38
	private float maxLenght; //Field offset: 0x3C
	private float lastLenghr; //Field offset: 0x40
	private float springLenght; //Field offset: 0x44
	private float springVelocity; //Field offset: 0x48
	private float springForce; //Field offset: 0x4C
	private float damperForce; //Field offset: 0x50
	private float inertiaOffset; //Field offset: 0x54
	public float wheelRadius; //Field offset: 0x58
	[CompilerGenerated]
	private Vector3 <SuspensionForce>k__BackingField; //Field offset: 0x5C

	public private Vector3 SuspensionForce
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public VehicleSuspensionSpring() { }

	public void CalculateBaseParams() { }

	private void FixedUpdate() { }

	[CompilerGenerated]
	public Vector3 get_SuspensionForce() { }

	[CompilerGenerated]
	private void set_SuspensionForce(Vector3 value) { }

	public void SetOffset(float offset) { }

	private void Start() { }

}

