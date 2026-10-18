namespace EFT;

public class ImpostorAnimator : UnityAnimatorWrapper, IDisposable
{
	private const int _mainAnimatorLayer = 0; //Field offset: 0x0
	private MovementContext _movementContext; //Field offset: 0x60
	private BaseMovementState _currentState; //Field offset: 0x68
	private float _currentStateTime; //Field offset: 0x70
	private float _normalizedTime; //Field offset: 0x74

	private ImpostorAnimator() { }

	public static ImpostorAnimator Create(Animator animator, MovementContext movementContext) { }

	public override void Dispose() { }

	public virtual AnimatorStateInfoWrapper GetCurrentAnimatorStateInfo(int layerIndex) { }

	private void OnClientAnimatorStateIndexChanged(int oldStateHashIndex, int newStateHashIndex) { }

	private void SetAnimatorState(int hash) { }

	private void SetMovementContext(MovementContext movementContext) { }

	public virtual void Update(float deltaTime) { }

}

