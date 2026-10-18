namespace EFT.UI;

[UsedImplicitly]
public sealed class StashRowsRewardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _image; //Field offset: 0x70
	[SerializeField]
	private Sprite _sprite; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _rewardCaptionField; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _rowsNumberField; //Field offset: 0x88
	private SimpleTooltip _tooltip; //Field offset: 0x90

	public StashRowsRewardView() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Show(QuestReward reward) { }

}

