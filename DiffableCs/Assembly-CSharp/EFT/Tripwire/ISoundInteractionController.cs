namespace EFT.Tripwire;

public interface ISoundInteractionController : IDisposable
{

	public void PlayInteractionSound(bool hasSpecialItem = false) { }

	public void StopInteractionSound(bool interactionSuccess, bool hasSpecialItem = false) { }

}

