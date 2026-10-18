//Type is in global namespace

public class GrassTrampler : MonoBehaviour
{
	private const string GRASSPOSITION = "_GrassPlayerPosition"; //Field offset: 0x0
	private const string GRASSDIRECTION = "_GrassPlayerDirection"; //Field offset: 0x0
	private const string GRASSVALUES = "_GrassValues"; //Field offset: 0x0
	[SerializeField]
	private AnimationCurve _angleCurve; //Field offset: 0x20
	[SerializeField]
	public float TransitionTimeBetweenStates; //Field offset: 0x28
	[SerializeField]
	public GrassValues StandGrassValues; //Field offset: 0x30
	[SerializeField]
	public GrassValues DuckGrassValues; //Field offset: 0x38
	[SerializeField]
	public GrassValues ProneGrassValues; //Field offset: 0x40
	private AnimationCurve _curve; //Field offset: 0x48
	private GrassValues _currenGrassValues; //Field offset: 0x50
	private Vector3 _playerPosition; //Field offset: 0x58
	private Vector3 _playerDirection; //Field offset: 0x64
	private Vector3 _lastPlayerDirection; //Field offset: 0x70
	private EPlayerPose _lastPlayerPose; //Field offset: 0x7C
	private bool _isTransitionToProne; //Field offset: 0x80
	private float _firstDeviationTime; //Field offset: 0x84
	private float _onePhaseTime; //Field offset: 0x88
	private float _switchPoseTime; //Field offset: 0x8C
	private float _startTimeOfMove; //Field offset: 0x90
	private float _lastMovingInSameDirectionTime; //Field offset: 0x94
	private float _animationDeltaTime; //Field offset: 0x98
	private GrassValues _startGrassValues; //Field offset: 0xA0
	private float _lastAngleInRads; //Field offset: 0xA8

	private Player Player
	{
		private get { } //Length: 60
	}

	private EPlayerPose PlayerPose
	{
		private get { } //Length: 144
	}

	public GrassTrampler() { }

	private void Awake() { }

	private void CalculateValues() { }

	private Player get_Player() { }

	private EPlayerPose get_PlayerPose() { }

	private GrassValues GetGrassValuesByPose() { }

	private float GetLyingDeviationAngle(float startTimeOfMove, float delta) { }

	private float GetStandingDeviationAngle(float startTimeOfMove, float delta) { }

	private void SetShaderValues() { }

	public void Update() { }

}

