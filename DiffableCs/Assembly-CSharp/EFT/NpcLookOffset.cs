namespace EFT;

public class NpcLookOffset : MonoBehaviour
{
	[SerializeField]
	private Transform _spineTransform; //Field offset: 0x20
	[SerializeField]
	private Animator _animator; //Field offset: 0x28
	[SerializeField]
	[Tooltip("Head turning speed")]
	private float _degreesPerSecond; //Field offset: 0x30
	[SerializeField]
	[Tooltip("Spine turning speed")]
	private float _degreesPerSecondSpine; //Field offset: 0x34
	[Range(0.2, 1)]
	[SerializeField]
	[Tooltip("Define percentage or current animState progress to fire the StopOffsetting trigger")]
	private float _animThreshold; //Field offset: 0x38
	[SerializeField]
	private float _gestureBlendSpeed; //Field offset: 0x3C
	private int _keeperXHash; //Field offset: 0x40
	private int _keeperYHash; //Field offset: 0x44
	private int _keeperXSpineHash; //Field offset: 0x48
	private int _keeperYSpineHash; //Field offset: 0x4C
	private int _keeperOffsetWeight; //Field offset: 0x50
	private float _offsetWeight; //Field offset: 0x54
	private float _targetValue; //Field offset: 0x58
	private int _keeperGestureTrigger; //Field offset: 0x5C
	private int _defaultStateHash; //Field offset: 0x60
	private Transform _targetTransform; //Field offset: 0x68
	private bool _gestureAnimInProgress; //Field offset: 0x70

	public NpcLookOffset() { }

	public void Awake() { }

	private void CheckGesturePercentage() { }

	private void DefineAnimatorHashes() { }

	public void OnPlayerEnter(EftGamePlayerOwner playerOwner, Transform cameraTransform) { }

	public void OnPlayerExit() { }

	private void TurnTraderToCam() { }

	public void Update() { }

}

