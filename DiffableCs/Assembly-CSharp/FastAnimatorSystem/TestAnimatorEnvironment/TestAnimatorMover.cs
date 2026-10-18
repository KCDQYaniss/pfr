namespace FastAnimatorSystem.TestAnimatorEnvironment;

public class TestAnimatorMover : MonoBehaviour
{
	public TestAnimatorSkeleton[] skeletons; //Field offset: 0x20
	public Slider aimAngleSlider; //Field offset: 0x28
	public Slider speedSlider; //Field offset: 0x30
	public Slider levelSlider; //Field offset: 0x38
	public Slider tiltSlider; //Field offset: 0x40
	public Slider deltaRotationSlider; //Field offset: 0x48
	public Slider firstActionSlider; //Field offset: 0x50
	public Text frameLabel; //Field offset: 0x58
	public bool showDeltaLog; //Field offset: 0x60
	public bool thirdPersonParam; //Field offset: 0x61
	public bool replayRecord; //Field offset: 0x62
	public bool applyDeltaPositionOnRecord; //Field offset: 0x63
	public string recordFilePath; //Field offset: 0x68
	public bool autoMove; //Field offset: 0x70
	public bool autoProne; //Field offset: 0x71
	public bool autoDeltaRotation; //Field offset: 0x72
	public bool autoJump; //Field offset: 0x73
	public int targetFrameRate; //Field offset: 0x74
	private readonly int _directX; //Field offset: 0x78
	private readonly int _directY; //Field offset: 0x7C
	private readonly int _inert; //Field offset: 0x80
	private readonly int _isJumping; //Field offset: 0x84
	private readonly int _isLanding; //Field offset: 0x88
	private readonly int _tilt; //Field offset: 0x8C
	private readonly int _level; //Field offset: 0x90
	private readonly int _aimAngle; //Field offset: 0x94
	private readonly int _speed; //Field offset: 0x98
	private readonly int _direct; //Field offset: 0x9C
	private readonly int _thirdPerson; //Field offset: 0xA0
	private readonly int _prone; //Field offset: 0xA4
	private readonly int _proneReload; //Field offset: 0xA8
	private readonly int _deltaRotation; //Field offset: 0xAC
	private readonly int _sprint; //Field offset: 0xB0
	private readonly int _firstAction; //Field offset: 0xB4
	private readonly int _footStep; //Field offset: 0xB8
	private readonly int _fallingDown; //Field offset: 0xBC
	private List _animators; //Field offset: 0xC0
	private float _prevDirX; //Field offset: 0xC8
	private float _prevDirY; //Field offset: 0xCC
	private bool _proneVal; //Field offset: 0xD0
	private bool _sprintVal; //Field offset: 0xD1
	private bool _proneReloadVal; //Field offset: 0xD2
	private bool _prevAutoMove; //Field offset: 0xD3
	private int recordCounter; //Field offset: 0xD4

	public TestAnimatorMover() { }

	private string QuatToStr(Quaternion vec) { }

	private void ShowLog() { }

	private void Start() { }

	private void Update() { }

	private string VecToStr(Vector3 vec) { }

}

