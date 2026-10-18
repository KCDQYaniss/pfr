namespace EFT.BotData;

public class CivilianBotWeaponSelector : BotWeaponSelector
{

	public CivilianBotWeaponSelector(BotOwner owner) { }

	protected virtual void FindItemsInSlots(bool anyway) { }

	protected virtual void OnWeaponTaken(Result x) { }

	protected virtual bool TryChangeToSlot(EquipmentSlot slot, bool changeToMain, Action callback = null) { }

}

