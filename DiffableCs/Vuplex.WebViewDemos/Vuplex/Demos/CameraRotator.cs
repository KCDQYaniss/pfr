namespace Vuplex.Demos;

internal class CameraRotator : MonoBehaviour
{
	public GameObject InstructionMessage; //Field offset: 0x20
	private bool _legacyInputManagerDisabled; //Field offset: 0x28
	private Vector2 _rotationFromMouse; //Field offset: 0x2C

	private void _warnIfVisionOS() { }

	public CameraRotator() { }

	private void Start() { }

	private void Update() { }

}

