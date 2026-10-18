namespace EFT.Expansions;

public sealed class ExpansionsShopNotificationData
{
	public EExpansionsShopNotificationSource Source; //Field offset: 0x10
	public EExpansionsNotificationType NotificationType; //Field offset: 0x14
	public string Title; //Field offset: 0x18
	public string Description; //Field offset: 0x20
	public string[] DescriptionArgs; //Field offset: 0x28
	public string IconName; //Field offset: 0x30
	public Nullable Balance; //Field offset: 0x38
	public Nullable BalanceDelta; //Field offset: 0x40
	public EBonusType[] BonusTypes; //Field offset: 0x48

	public ExpansionsShopNotificationData() { }

}

