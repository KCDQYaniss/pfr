namespace GPUInstancer;

public class SpaceshipMobileJoystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[HideInInspector]
	public Vector3 inputDirection; //Field offset: 0x20
	private Image joystickBase; //Field offset: 0x30
	private Image joystick; //Field offset: 0x38
	private Vector2 dragPosition; //Field offset: 0x40

	public SpaceshipMobileJoystick() { }

	public override void OnDrag(PointerEventData data) { }

	public override void OnPointerDown(PointerEventData data) { }

	public override void OnPointerUp(PointerEventData data) { }

	private void Start() { }

}

