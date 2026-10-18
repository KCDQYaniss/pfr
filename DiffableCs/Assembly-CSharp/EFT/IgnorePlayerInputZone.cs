namespace EFT;

public class IgnorePlayerInputZone : MonoBehaviour
{
	[SerializeField]
	private BaseEventFilter _setIgnoreInputFilter; //Field offset: 0x20
	[SerializeField]
	private BaseEventFilter _giveInputBackFilter; //Field offset: 0x28
	[SerializeField]
	private bool canRotateHead; //Field offset: 0x30

	public IgnorePlayerInputZone() { }

	private void Awake() { }

	private void GiveInputBack(BaseEventFilter filter, BaseEvent passedEvent) { }

	private void SetIgnoreInput(BaseEventFilter filter, BaseEvent passedEvent) { }

}

