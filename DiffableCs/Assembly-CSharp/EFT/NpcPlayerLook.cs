namespace EFT;

public class NpcPlayerLook : MonoBehaviour
{
	[SerializeField]
	private Transform _npcHead; //Field offset: 0x20
	[SerializeField]
	private float _lookSpeed; //Field offset: 0x28
	[SerializeField]
	private float _dampingAngleMin; //Field offset: 0x2C
	[SerializeField]
	private float _dampingAngleMax; //Field offset: 0x30
	[SerializeField]
	private AnimationCurve _speedCurve; //Field offset: 0x38
	private Transform _playerCameraTransform; //Field offset: 0x40

	public NpcPlayerLook() { }

	private void Awake() { }

	public void OnPlayerEnter(EftGamePlayerOwner playerOwner, Transform cameraTransform) { }

	public void OnPlayerExit() { }

	private void Update() { }

}

