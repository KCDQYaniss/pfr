namespace EFT.Dialogs;

public interface ITraderAnimationController
{

	public NPCObject Animator
	{
		 get { } //Length: 0
	}

	public ClientDialogController ClientDialogController
	{
		 get { } //Length: 0
	}

	public Task ExecuteDialogOption(CombinedAnimationData animationData) { }

	public NPCObject get_Animator() { }

	public ClientDialogController get_ClientDialogController() { }

	public void SkipAnimation() { }

}

