namespace EFT.UI;

public sealed class CustomizationOfferRewardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private struct <LoadClothingIcon>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomizationClothing clothing; //Field offset: 0x20
		public CustomizationOfferRewardView <>4__this; //Field offset: 0x28
		private int <requestIndex>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForIcon>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomizationOfferRewardView <>4__this; //Field offset: 0x20
		public int requestIndex; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TMP_Text _suitName; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _rewardTypeName; //Field offset: 0x78
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	[SerializeField]
	private GameObject _iconLoader; //Field offset: 0x88
	private SimpleTooltip _tooltip; //Field offset: 0x90
	private ClothingIcon _clothingIcon; //Field offset: 0x98
	private string _tooltipDescription; //Field offset: 0xA0
	private Token _bundles; //Field offset: 0xA8
	private int _requestIndex; //Field offset: 0xB0

	public CustomizationOfferRewardView() { }

	private void ApplyIconState() { }

	public virtual void Close() { }

	private CustomizationClothing GetClothing(QuestReward reward) { }

	[AsyncStateMachine(typeof(<LoadClothingIcon>d__10))]
	private Task LoadClothingIcon(CustomizationClothing clothing) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	private void SetIconLoadingState(bool isLoading) { }

	public void Show(QuestReward reward) { }

	[AsyncStateMachine(typeof(<WaitForIcon>d__13))]
	private Task WaitForIcon(int requestIndex) { }

}

