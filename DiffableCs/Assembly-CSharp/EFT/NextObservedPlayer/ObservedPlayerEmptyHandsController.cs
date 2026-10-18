namespace EFT.NextObservedPlayer;

public class ObservedPlayerEmptyHandsController : BaseObservedPlayerHandsController
{

	public ObservedPlayerEmptyHandsController(BaseAnimationHandsController handsAnimationController) { }

	public static ObservedPlayerEmptyHandsController CreateInstance(GameObject gameObject) { }

	public virtual Task Execute(ICommandMessage command) { }

}

