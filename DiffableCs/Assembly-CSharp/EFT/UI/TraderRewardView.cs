namespace EFT.UI;

public sealed class TraderRewardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private TMP_Text _traderName; //Field offset: 0x70
	[SerializeField]
	private Image _avatar; //Field offset: 0x78
	private SimpleTooltip _tooltip; //Field offset: 0x80

	public TraderRewardView() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(QuestReward reward) { }

}

