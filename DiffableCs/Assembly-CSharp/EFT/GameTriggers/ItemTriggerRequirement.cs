namespace EFT.GameTriggers;

public class ItemTriggerRequirement : ITriggerRequirement, IDisposable
{
	private const string TOOLKIT_ID = "590c2e1186f77425357b6124"; //Field offset: 0x0
	[SerializeField]
	private string _itemRequirementId; //Field offset: 0x10

	public ItemTriggerRequirement() { }

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	public override void Dispose() { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

