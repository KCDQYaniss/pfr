namespace EFT.GameTriggers;

public class HasSniperImmunityTriggerRequirement : ITriggerRequirement, IDisposable
{
	[SerializeField]
	private PlayersWithImmuneToSniperFire _sniperZoneImmune; //Field offset: 0x10

	public HasSniperImmunityTriggerRequirement() { }

	private bool Check(string profileId) { }

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	public override void Dispose() { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

