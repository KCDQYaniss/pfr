namespace EFT.UI.Seasons;

public class BattlePassUITutorial : MonoBehaviour
{
	public const string PREFS_KEY = "UITutorial/BattlePass"; //Field offset: 0x0
	[SerializeField]
	private UITutorialController _tutorialController; //Field offset: 0x20
	[SerializeField]
	private RectTransform[] _stepTargets; //Field offset: 0x28
	[SerializeField]
	private UITutorialHintAnchor[] _hintAnchors; //Field offset: 0x30
	[SerializeField]
	private UITutorialFocusArea _step4FocusArea; //Field offset: 0x38
	[SerializeField]
	private UITutorialFocusArea _step8FocusArea; //Field offset: 0x40
	[SerializeField]
	private RectTransform _step4Tooltip; //Field offset: 0x48

	public bool IsCompleted
	{
		 get { } //Length: 161
	}

	public BattlePassUITutorial() { }

	public bool get_IsCompleted() { }

	public Task Show(BattlePass battlePass) { }

}

