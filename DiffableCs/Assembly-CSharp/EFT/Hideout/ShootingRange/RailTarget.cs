namespace EFT.Hideout.ShootingRange;

[RequireComponent(typeof(FoldingTarget))]
public class RailTarget : MonoBehaviour, IFoldingTarget
{
	private enum HorizontalDirection
	{
		Right = 0,
		Left = 1,
	}

	internal enum MovementSpeed
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	private enum MovementType
	{
		Default = 0,
		Horizontal = 1,
		Vertical = 2,
	}

	private enum VerticalDirection
	{
		Forward = 0,
		Backward = 1,
	}

	[SerializeField]
	[Space]
	private int _row; //Field offset: 0x20
	[SerializeField]
	[Space]
	private Transform _leftPoint; //Field offset: 0x28
	[SerializeField]
	private Transform _rightPoint; //Field offset: 0x30
	[SerializeField]
	private Transform _frontPoint; //Field offset: 0x38
	[SerializeField]
	[Space]
	private float _lowMovementSpeed; //Field offset: 0x40
	[SerializeField]
	private float _mediumMovementSpeed; //Field offset: 0x44
	[SerializeField]
	private float _highMovementSpeed; //Field offset: 0x48
	[SerializeField]
	private float _inspectMovementSpeed; //Field offset: 0x4C
	[SerializeField]
	private PaperTarget _paperTarget; //Field offset: 0x50
	[SerializeField]
	[Space]
	private Transform _target; //Field offset: 0x58
	[SerializeField]
	private Transform _rail; //Field offset: 0x60
	[SerializeField]
	[Space]
	private AudioSource _shootingStartAudio; //Field offset: 0x68
	[SerializeField]
	private AudioSource _shootingStopAudio; //Field offset: 0x70
	[SerializeField]
	private AudioSource _shootingLoopAudio; //Field offset: 0x78
	[SerializeField]
	private AudioSource[] _inspectLoopAudios; //Field offset: 0x80
	private Vector3 _defaultTargetPosition; //Field offset: 0x88
	private Vector3 _defaultRailPosition; //Field offset: 0x94
	private HorizontalDirection _targetDirection; //Field offset: 0xA0
	private VerticalDirection _railDirection; //Field offset: 0xA4
	private int CurrentIndexMovementSpeed; //Field offset: 0xA8
	private float[] _movementSpeeds; //Field offset: 0xB0
	private MovementType _currentMovement; //Field offset: 0xB8
	private Sequence _currentSequence; //Field offset: 0xC0
	private FoldingTarget _foldingTarget; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnHitTarget; //Field offset: 0xD0
	private readonly float _defaultShootingLoopPitch; //Field offset: 0xD8
	private readonly float _shootingLoopPitchIncrease; //Field offset: 0xDC

	public event Action OnHitTarget
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public bool Folded
	{
		 get { } //Length: 33
	}

	public bool Ready
	{
		 get { } //Length: 33
	}

	public int Row
	{
		 get { } //Length: 4
	}

	public bool Unfolded
	{
		 get { } //Length: 33
	}

	public RailTarget() { }

	[CompilerGenerated]
	public void add_OnHitTarget(Action value) { }

	private void Awake() { }

	public override Task Fold(bool mute, CancellationToken token) { }

	public bool get_Folded() { }

	public bool get_Ready() { }

	public int get_Row() { }

	public bool get_Unfolded() { }

	private void HandleHitTarget(TargetColliderType targetColliderType, int segmentTarget) { }

	private Task Inspect(CancellationToken token) { }

	public void InspectStart() { }

	public void InspectStop() { }

	private void OnCompleteInspect() { }

	private void OnCompleteResetInspect() { }

	private void OnCompleteResetShooting() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	private void OnKillInspect() { }

	private void OnKillResetInspect() { }

	private void OnKillResetShooting() { }

	private void OnKillShooting() { }

	private void OnStartInspect() { }

	private void OnStartResetInspect() { }

	private void OnStartResetShooting() { }

	private void OnStartShooting() { }

	private void OnStartShootingLeft() { }

	private void OnStartShootingRight() { }

	[CompilerGenerated]
	public void remove_OnHitTarget(Action value) { }

	private Task ResetInspect(CancellationToken token) { }

	private Task ResetShooting(CancellationToken token) { }

	public Task RestoreInspect(CancellationToken token) { }

	public override Task Rocking(CancellationToken token) { }

	public void SetMovementSpeed(int currentMovementSpeed) { }

	private Task Shooting(CancellationToken token) { }

	private Tween ShootingBegin() { }

	private Tween ShootingLeft(float duration) { }

	private Tween ShootingLoop() { }

	private Tween ShootingRight(float duration) { }

	public void ShootingStart(int speed) { }

	public void ShootingStop() { }

	private void Start() { }

	public bool TryInspect(CancellationToken token, out Task task) { }

	public bool TryResetInspect(CancellationToken token, out Task tween) { }

	public bool TryResetShooting(CancellationToken token, out Task tween) { }

	public bool TryRestoreInspect(CancellationToken token, out Task tween) { }

	public bool TryShooting(CancellationToken token, out Task task) { }

	public override Task Unfold(bool mute, CancellationToken token) { }

}

