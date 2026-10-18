namespace EFT.UI.Seasons;

public abstract class SeasonalRewardView`1 : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
	private readonly BindableEvent _onSelected; //Field offset: 0x0
	[SerializeField]
	private Image _image; //Field offset: 0x0
	[SerializeField]
	private Button _previewButton; //Field offset: 0x0
	[SerializeField]
	private Button _playSoundButton; //Field offset: 0x0
	[SerializeField]
	private Button _playAnimationButton; //Field offset: 0x0
	[SerializeField]
	private TradingOfferTooltipArea _barterInfoButton; //Field offset: 0x0
	[SerializeField]
	private HoverTooltipArea _craftInfoButton; //Field offset: 0x0
	[SerializeField]
	private List _selectedStateObjects; //Field offset: 0x0
	[SerializeField]
	private List _normalStateObjects; //Field offset: 0x0
	private RewardDetailsActionState _rewardActions; //Field offset: 0x0
	[CompilerGenerated]
	private TReward <Reward>k__BackingField; //Field offset: 0x0

	public IBindableEvent OnSelected
	{
		 get { } //Length: 5
	}

	protected private TReward Reward
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected SeasonalRewardView`1() { }

	public IBindableEvent get_OnSelected() { }

	[CompilerGenerated]
	protected TReward get_Reward() { }

	protected override void OnPointerClick() { }

	protected override void OnPointerDown() { }

	protected override void OnPointerEnter() { }

	protected override void OnPointerExit() { }

	protected override void OnPointerUp() { }

	[CompilerGenerated]
	private void set_Reward(TReward value) { }

	public void SetState(bool selected) { }

	private void SetupActionButtons(PrestigeReward reward) { }

	protected void Show(TReward reward, IImageLoader imageLoader) { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}

