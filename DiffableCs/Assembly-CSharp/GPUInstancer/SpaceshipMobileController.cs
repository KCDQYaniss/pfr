namespace GPUInstancer;

public class SpaceshipMobileController : MonoBehaviour
{
	public float engineTorque; //Field offset: 0x20
	public float enginePower; //Field offset: 0x24
	public SpaceshipMobileJoystick spaceShipJoystick; //Field offset: 0x28
	private Rigidbody shipRigidbody; //Field offset: 0x30
	private float rollInput; //Field offset: 0x38
	private float thrustInput; //Field offset: 0x3C
	private float pitchInput; //Field offset: 0x40
	private float yawInput; //Field offset: 0x44
	private EmissionModule engineThrusterEmission; //Field offset: 0x48
	private EmissionModule engineGlowEmission; //Field offset: 0x50
	private Light engineGlowLight; //Field offset: 0x58
	private float originalThrusterEmissionRate; //Field offset: 0x60
	private float originalGlowEmissionRate; //Field offset: 0x64

	public SpaceshipMobileController() { }

	private void AdjustThrusterEffects() { }

	private void Awake() { }

	private void FixedUpdate() { }

	private void GetJoystickInput() { }

	private void Move() { }

	public void SetRollInput(float rollInput) { }

	public void SetThrustInput(bool isThrusting) { }

}

