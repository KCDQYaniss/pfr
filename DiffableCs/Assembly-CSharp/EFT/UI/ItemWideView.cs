namespace EFT.UI;

public sealed class ItemWideView : ItemIconView, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__10_0(bool _, PointerEventData _) { }

	}

	[SerializeField]
	private TMP_Text _name; //Field offset: 0xA8
	[SerializeField]
	private TMP_Text _itemTypeName; //Field offset: 0xB0
	[SerializeField]
	private Image _unlockRewardIcon; //Field offset: 0xB8
	[SerializeField]
	private TradingOfferTooltipArea _tradingOfferTooltipArea; //Field offset: 0xC0
	[SerializeField]
	private GameObject _foundInRaid; //Field offset: 0xC8
	[SerializeField]
	private Sprite _schemeUnlockSprite; //Field offset: 0xD0
	private SimpleTooltip _tooltip; //Field offset: 0xD8
	private ERewardType _rewardType; //Field offset: 0xE0
	private string _tooltipDescription; //Field offset: 0xE8
	private bool _isTooltipParented; //Field offset: 0xF0

	public ItemWideView() { }

	public void OnDisable() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetDescription(QuestReward reward, bool isStartReward) { }

	private void SetGeneratedInRaid(bool state) { }

	private void SetupTradingOfferTooltip(QuestReward reward) { }

	public void Show(QuestReward reward, bool isStartReward) { }

	private void TryHideTooltip() { }

	protected virtual void UpdateScale() { }

}

