namespace EFT.Tutorial;

public abstract class BaseTriggerZoneTutorialHintController : BaseTutorialHintController
{
	private Action _dispose; //Field offset: 0x30

	protected BaseTriggerZoneTutorialHintController(TutorialHintData hint, Player player, Action showHint, Action closeHint) { }

	public virtual void Dispose() { }

	protected abstract void TriggerZoneEventHandler(TriggerEvent triggerEvent) { }

}

