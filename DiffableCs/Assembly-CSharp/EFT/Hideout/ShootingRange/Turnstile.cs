namespace EFT.Hideout.ShootingRange;

public class Turnstile : InteractiveShootingRange
{
	[Range(0, 1)]
	[SerializeField]
	private float _duration; //Field offset: 0x50
	[SerializeField]
	private bool _opened; //Field offset: 0x54
	private Quaternion _openRotation; //Field offset: 0x58
	private Quaternion _closeRotation; //Field offset: 0x68
	private float _defaultAngle; //Field offset: 0x78
	private Tween _currentTween; //Field offset: 0x80

	public Turnstile() { }

	private void Awake() { }

	public void Close() { }

	private float GetDuration(Quaternion leftRotation, Quaternion rightRotation) { }

	public virtual AvailableInteractionState InteractionStates(HideoutPlayerOwner owner) { }

	public void Open() { }

}

