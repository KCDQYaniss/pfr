//Type is in global namespace

public class StatedUIButtonAnimation : SerializedMonoBehaviour, IButtonAnimation, ITweenAnimation
{
	[SerializeField]
	private Dictionary _states; //Field offset: 0x60

	public StatedUIButtonAnimation() { }

	private void ChangeState(EButtonAnimationState state) { }

	public override void SetState(EButtonAnimationState state) { }

	public override void Stop() { }

	public override void TransitionToState(EButtonAnimationState state) { }

}

