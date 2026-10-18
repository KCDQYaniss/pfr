namespace EFT.GameTriggers;

public abstract class TriggersModule : MonoBehaviour
{
	private List _onDestroy; //Field offset: 0x20

	protected TriggersModule() { }

	public abstract bool ApplyDamage(int playerRaidId, DamageData[] damageData) { }

	public bool Check(ITriggerRequirement triggerRequirement, int playerRaidId) { }

	public abstract void Interact(WorldInteractiveObject wio, EInteractionType interactionType, int profileId) { }

	public abstract void Interact(string interactableId, EInteractionType interactionType, int playerRaidId) { }

	private void OnDestroy() { }

	protected abstract bool TryFindInteractiveObject(string id, out WorldInteractiveObject result) { }

	public abstract bool TryFindInventoryController(int playerRaidId, out InventoryController inventoryController) { }

	protected abstract bool TryFindSkillManager(int playerRaidId, out SkillManager result) { }

	public abstract bool TryGetHealthsController(int playerRaidId, out ActiveHealthController healthController) { }

	public abstract bool TryGetQuestController(int playerRaidId, out QuestController questController) { }

	public bool TryRedeem(ITriggerRequirement triggerRequirement, int playerRaidId) { }

	protected abstract IEnumerable WorldInteractiveObjects() { }

}

