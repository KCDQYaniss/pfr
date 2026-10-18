namespace FastAnimatorSystem;

public sealed class AnimatedState : AbstractAnimatorControllerState
{
	public readonly AbstractMotion ClipInfo; //Field offset: 0x70
	private readonly bool _cachedLooped; //Field offset: 0x78

	public virtual bool Loop
	{
		 get { } //Length: 5
	}

	protected virtual float RealMotionDuration
	{
		 get { } //Length: 28
	}

	public AnimatedState(string name, int hash, List outTransitions, float speedMultiplier, AnimatorParameter speedAnimParam, AbstractMotion clipInfo) { }

	public AnimatedState(string name, int hash, float speedMultiplier, AnimatorParameter speedAnimParam, AbstractMotion clipInfo) { }

	public virtual bool get_Loop() { }

	protected virtual float get_RealMotionDuration() { }

	public virtual string ToString() { }

}

