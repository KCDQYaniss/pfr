namespace EFT.UI.Prestige;

[UsedImplicitly]
public class PrestigeRewardView : UIElement, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private RectTransform _sizeContainer; //Field offset: 0x70
	[SerializeField]
	private Image _icon; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _rewardType; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _rewardName; //Field offset: 0x88
	[SerializeField]
	private GameObject _highlight; //Field offset: 0x90
	[SerializeField]
	private GameObject _background_1; //Field offset: 0x98
	[SerializeField]
	private GameObject _background_2; //Field offset: 0xA0
	private PrestigeReward _reward; //Field offset: 0xA8
	private readonly BindableEvent _onClick; //Field offset: 0xB0
	private readonly BindableState _selectionState; //Field offset: 0xB8

	public IBindableEvent OnClick
	{
		 get { } //Length: 8
	}

	public PrestigeRewardView() { }

	public IBindableEvent get_OnClick() { }

	private void SelectionStateHandler(bool selected) { }

	public void SetCurrentReward(PrestigeReward currentReward) { }

	public void Show(PrestigeReward reward, IImageLoader session, GridLayoutGroup layoutGroup) { }

	protected override bool TryOverrideName(PrestigeReward reward, out string newName) { }

	protected override bool TryOverrideRewardType(PrestigeReward reward, out string newName) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

}

