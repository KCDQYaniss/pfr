namespace EFT.GameTriggers;

public class GameObjectStateTriggerRequirement : ITriggerRequirement, IDisposable
{
	[SerializeField]
	private GameObject _targetGameObject; //Field offset: 0x10
	[SerializeField]
	private bool _requiredState; //Field offset: 0x18

	public GameObjectStateTriggerRequirement() { }

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	private bool Check() { }

	public override void Dispose() { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

