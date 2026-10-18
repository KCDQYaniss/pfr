namespace EFT.GameTriggers;

public class QuestTriggerRequirement : ITriggerRequirement, IDisposable
{
	[SerializeField]
	private string _questTemplateId; //Field offset: 0x10
	[SerializeField]
	private bool _includeMarkedAsFailed; //Field offset: 0x18

	public QuestTriggerRequirement() { }

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	public override void Dispose() { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

