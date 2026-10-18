namespace EFT.UI.Seasons;

public abstract class BattlePassBaseRewardRequirementView : UIElement
{
	internal enum ERequirementState
	{
		Disabled = 0,
		Active = 1,
		Complete = 2,
	}

	[SerializeField]
	private GameObject _checkbox; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _descriptionField; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _countField; //Field offset: 0x80
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x88

	protected abstract int CurrentCount
	{
		 get { } //Length: 0
	}

	protected abstract ERequirementState CurrentState
	{
		 get { } //Length: 0
	}

	protected abstract string LocalizedText
	{
		 get { } //Length: 0
	}

	protected abstract int MaxCount
	{
		 get { } //Length: 0
	}

	protected override bool ShowCount
	{
		 get { } //Length: 3
	}

	protected BattlePassBaseRewardRequirementView() { }

	[CompilerGenerated]
	private void <Show>b__15_0(BattlePassReward _) { }

	protected abstract int get_CurrentCount() { }

	protected abstract ERequirementState get_CurrentState() { }

	protected abstract string get_LocalizedText() { }

	protected abstract int get_MaxCount() { }

	protected override bool get_ShowCount() { }

	protected override void RewardClaimedHandler() { }

	protected void Show(BattlePass battlePass) { }

	protected void UpdateCount() { }

	protected void UpdateState() { }

}

