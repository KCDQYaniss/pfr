namespace EFT.UI;

public sealed class QuestRewardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private TMP_Text _questName; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _rewardTypeName; //Field offset: 0x78
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	private SimpleTooltip _tooltip; //Field offset: 0x88

	public QuestRewardView() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(QuestReward reward) { }

}

