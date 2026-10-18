namespace EFT.Achievements;

public sealed class AchievementView : UIElement, IAchievementView, IUIView, IDisposable
{
	[SerializeField]
	private Image _templateBackground; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _titleText; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _descriptionText; //Field offset: 0x80
	[SerializeField]
	private HoverTrigger _progressBar; //Field offset: 0x88
	[SerializeField]
	private Image _progressBarImage; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _progressText; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _globalProgressText; //Field offset: 0xA0
	[SerializeField]
	private TMP_Text _unlockDateText; //Field offset: 0xA8
	[SerializeField]
	private Color _defaultUnlockDateTextColor; //Field offset: 0xB0
	[SerializeField]
	private Color _legendaryUnlockDateTextColor; //Field offset: 0xC0
	[SerializeField]
	private Color _seasonalUnlockDateTextColor; //Field offset: 0xD0
	[SerializeField]
	private AchievementIconView _achievementIconView; //Field offset: 0xE0
	[SerializeField]
	private List _labels; //Field offset: 0xE8
	[SerializeField]
	private Sprite _commonBackground; //Field offset: 0xF0
	[SerializeField]
	private Sprite _rareBackground; //Field offset: 0xF8
	[SerializeField]
	private Sprite _legendaryBackground; //Field offset: 0x100
	[SerializeField]
	private Sprite _seasonalBackground; //Field offset: 0x108
	private NotesTaskDescriptionShort _taskDescription; //Field offset: 0x110
	private AchievementsController _achievementsController; //Field offset: 0x118
	private IImageLoader _session; //Field offset: 0x120
	[CompilerGenerated]
	private Achievement <Achievement>k__BackingField; //Field offset: 0x128

	public private override Achievement Achievement
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public AchievementView() { }

	private void Awake() { }

	private override void EFT.Achievements.IAchievementView.Show(Achievement model, AchievementsController achievementsController, NotesTaskDescriptionShort description, IClientSession session) { }

	[CompilerGenerated]
	public override Achievement get_Achievement() { }

	public void HideConditionsTooltip(PointerEventData eventData) { }

	public void HideRewardsTooltip(PointerEventData eventData) { }

	[CompilerGenerated]
	private void set_Achievement(Achievement value) { }

	private void SetupImages() { }

	private void SetupProgress() { }

	private void SetupText() { }

	public void ShowConditionsTooltip(PointerEventData eventData) { }

	public void ShowRewardsTooltip(PointerEventData eventData) { }

}

