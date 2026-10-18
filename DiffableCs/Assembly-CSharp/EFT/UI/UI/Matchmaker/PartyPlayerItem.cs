namespace EFT.UI.UI.Matchmaker;

public sealed class PartyPlayerItem : ButtonFeedback
{
	[SerializeField]
	private PlayerLevelPanel _levelPanel; //Field offset: 0xA8
	[SerializeField]
	private ChatSpecialIcon _chatSpecialIcon; //Field offset: 0xB0
	[SerializeField]
	private GameObject _hoverBg; //Field offset: 0xB8
	[SerializeField]
	private GameObject _borderNormal; //Field offset: 0xC0
	[SerializeField]
	private GameObject _borderLeader; //Field offset: 0xC8
	[SerializeField]
	private DefaultUiButtonNewStyle _eyeButton; //Field offset: 0xD0
	private RaidPlayer _raidPlayer; //Field offset: 0xD8
	[CompilerGenerated]
	private Action OnViewEquipmentClick; //Field offset: 0xE0
	[CompilerGenerated]
	private Action OnPlayerNameClick; //Field offset: 0xE8

	public event Action OnPlayerNameClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnViewEquipmentClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public PartyPlayerItem() { }

	[CompilerGenerated]
	private void <Show>b__13_0() { }

	[CompilerGenerated]
	public void add_OnPlayerNameClick(Action value) { }

	[CompilerGenerated]
	public void add_OnViewEquipmentClick(Action value) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	protected virtual void PointerEnterHandler() { }

	protected virtual void PointerExitHandler() { }

	[CompilerGenerated]
	public void remove_OnPlayerNameClick(Action value) { }

	[CompilerGenerated]
	public void remove_OnViewEquipmentClick(Action value) { }

	public void SetEyeButtonAvailability(bool available) { }

	public void Show(RaidPlayer raidPlayer) { }

}

