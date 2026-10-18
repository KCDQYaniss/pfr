namespace EFT.GameTriggers;

public interface ITriggerRequirement : IDisposable
{

	public bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	public void Start() { }

	public bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

