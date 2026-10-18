//Type is in global namespace

public class FinalStatisticsAchievement : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private const float PUSH_DURATION = 0.2; //Field offset: 0x0
	[SerializeField]
	private AchievementIconView _achievementIconView; //Field offset: 0x70
	[SerializeField]
	private Image _templateBackground; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	[SerializeField]
	private Sprite _commonBackground; //Field offset: 0x88
	[SerializeField]
	private Sprite _rareBackground; //Field offset: 0x90
	[SerializeField]
	private Sprite _legendaryBackground; //Field offset: 0x98
	[SerializeField]
	private Sprite _seasonalBackground; //Field offset: 0xA0
	[CompilerGenerated]
	private Achievement <Achievement>k__BackingField; //Field offset: 0xA8
	private IImageLoader _session; //Field offset: 0xB0
	private FinalAchievementTooltip _finalAchievementTooltip; //Field offset: 0xB8

	public private Achievement Achievement
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public FinalStatisticsAchievement() { }

	[CompilerGenerated]
	public Achievement get_Achievement() { }

	public void HideTooltip(PointerEventData eventData) { }

	public void Init(Achievement model, IImageLoader session, FinalAchievementTooltip finalAchievementTooltip) { }

	[CompilerGenerated]
	private void set_Achievement(Achievement value) { }

	private void SetupImages() { }

	public void Show() { }

	public void ShowTooltip(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

}

