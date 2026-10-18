namespace EFT.Tutorial;

public sealed class HydrationTutorialHintController : BaseTriggerZoneTutorialHintController
{
	private const float HYDRATION_VALUE = 15; //Field offset: 0x0
	private const float ENERGY_VALUE = 15; //Field offset: 0x0
	private bool _valuesChangeCompleted; //Field offset: 0x38

	public HydrationTutorialHintController(TutorialHintData hint, Player player, Action showHint, Action closeHint) { }

	protected virtual void TriggerZoneEventHandler(TriggerEvent triggerEvent) { }

}

