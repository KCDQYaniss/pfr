namespace EFT.UI;

public sealed class AchievementNotificationView : BaseNotificationView, INotificationView
{
	[SerializeField]
	[Space]
	private Image _achievementIcon; //Field offset: 0xE8
	[SerializeField]
	private Image _iconBorder; //Field offset: 0xF0
	[SerializeField]
	private Image _iconBackground; //Field offset: 0xF8
	[SerializeField]
	private Image _backgroundGlow; //Field offset: 0x100
	[SerializeField]
	[Space]
	private Sprite _commonIconBorder; //Field offset: 0x108
	[SerializeField]
	private Sprite _rareIconBorder; //Field offset: 0x110
	[SerializeField]
	private Sprite _legendaryIconBorder; //Field offset: 0x118
	[SerializeField]
	private Sprite _seasonalIconBorder; //Field offset: 0x120
	[SerializeField]
	[Space]
	private Sprite _commonIconBackground; //Field offset: 0x128
	[SerializeField]
	private Sprite _rareIconBackground; //Field offset: 0x130
	[SerializeField]
	private Sprite _legendaryIconBackground; //Field offset: 0x138
	[SerializeField]
	private Sprite _seasonalIconBackground; //Field offset: 0x140
	[SerializeField]
	[Space]
	private Sprite _commonBackgroundGlow; //Field offset: 0x148
	[SerializeField]
	private Sprite _rareBackgroundGlow; //Field offset: 0x150
	[SerializeField]
	private Sprite _legendaryBackgroundGlow; //Field offset: 0x158
	[SerializeField]
	private Sprite _seasonalBackgroundGlow; //Field offset: 0x160

	public virtual bool ReturnToPool
	{
		 get { } //Length: 3
	}

	public AchievementNotificationView() { }

	public virtual bool get_ReturnToPool() { }

	public override void Init(NotificationAchievement notification) { }

}

