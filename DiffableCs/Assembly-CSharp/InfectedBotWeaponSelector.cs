//Type is in global namespace

public class InfectedBotWeaponSelector : BotWeaponSelector
{

	public InfectedBotWeaponSelector(BotOwner owner) { }

	protected virtual void FindItemsInSlots(bool anyway) { }

	private bool IsMeleeInfected() { }

	protected virtual void OnWeaponTaken(Result x) { }

	protected virtual bool TryChangeToSlot(EquipmentSlot slot, bool changeToMain, Action callback = null) { }

}

