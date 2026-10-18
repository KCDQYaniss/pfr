namespace EFT.UI;

public sealed class ExpansionsNotificationView : BaseNotificationView, INotificationView
{
	private const string LOCALE_PREFIX = "Expansions/Notification"; //Field offset: 0x0
	[SerializeField]
	[Space]
	private CustomTextMeshProUGUI _title; //Field offset: 0xE8
	[SerializeField]
	[Space]
	private Sprite _defaultBackgroundSprite; //Field offset: 0xF0
	[SerializeField]
	private Sprite _defaultIconSprite; //Field offset: 0xF8
	[SerializeField]
	private ExpansionsNotificationVisualSettingsDictionary _visualSettings; //Field offset: 0x100
	[SerializeField]
	private ExpansionsNotificationBrowserIconDictionary _browserIcons; //Field offset: 0x108

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public ExpansionsNotificationView() { }

	private void ApplyVisualSettings(ExpansionsShopNotificationData shopData) { }

	private void ApplyVisualSettings(Sprite background, Sprite icon) { }

	public virtual bool get_ReturnToPool() { }

	internal static string GetDescription(NotificationExpansions notification) { }

	protected virtual float GetHeight() { }

	private Sprite GetIcon(ExpansionsShopNotificationData shopData, ExpansionsNotificationVisualSettings visualSettings) { }

	private static string GetLocalizedDescription(ExpansionsShopNotificationData shopData) { }

	private static string GetLocalizedTitle(ExpansionsShopNotificationData shopData) { }

	private static string GetTitle(ExpansionsShopNotificationData shopData) { }

	public override void Init(NotificationExpansions notification) { }

}

