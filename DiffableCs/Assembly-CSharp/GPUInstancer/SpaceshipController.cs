namespace GPUInstancer;

public class SpaceshipController : MonoBehaviour
{
	public float engineTorque; //Field offset: 0x20
	public float enginePower; //Field offset: 0x24
	private Rigidbody shipRigidbody; //Field offset: 0x28
	private float rollInput; //Field offset: 0x30
	private float thrustInput; //Field offset: 0x34
	private float pitchInput; //Field offset: 0x38
	private float yawInput; //Field offset: 0x3C
	private EmissionModule engineThrusterEmission; //Field offset: 0x40
	private EmissionModule engineGlowEmission; //Field offset: 0x48
	private Light engineGlowLight; //Field offset: 0x50
	private float originalThrusterEmissionRate; //Field offset: 0x58
	private float originalGlowEmissionRate; //Field offset: 0x5C

	public SpaceshipController() { }

	private void AdjustThrusterEffects() { }

	private void Awake() { }

	private void FixedUpdate() { }

	private void GetInputs() { }

	private void Move() { }

}

