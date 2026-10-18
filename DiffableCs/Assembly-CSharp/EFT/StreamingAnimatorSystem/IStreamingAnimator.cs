namespace EFT.StreamingAnimatorSystem;

public interface IStreamingAnimator
{

	public IEventBehaviour[] EventBehaviours
	{
		 get { } //Length: 0
	}

	public void ClearData() { }

	public IEventBehaviour[] get_EventBehaviours() { }

	public void SetDonorAnimator(IAnimator weaponAnimator) { }

}

