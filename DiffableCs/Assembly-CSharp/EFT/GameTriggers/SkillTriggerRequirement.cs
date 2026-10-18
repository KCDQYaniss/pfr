namespace EFT.GameTriggers;

public class SkillTriggerRequirement : ITriggerRequirement, IDisposable
{
	[SerializeField]
	private ESkillId _skillId; //Field offset: 0x10
	[SerializeField]
	private int _minLevel; //Field offset: 0x14

	public SkillTriggerRequirement() { }

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	public override void Dispose() { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

