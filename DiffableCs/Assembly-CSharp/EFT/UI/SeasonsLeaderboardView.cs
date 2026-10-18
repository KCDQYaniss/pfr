namespace EFT.UI;

public class SeasonsLeaderboardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private struct <<SetupPlayer>g__RebuildLayout|23_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SeasonsLeaderboardView <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static ChatSpecialIconSettings _iconsSettings; //Field offset: 0x0
	[SerializeField]
	private GameObject _playerState; //Field offset: 0x70
	[SerializeField]
	private TMP_Text _placeLabel; //Field offset: 0x78
	[SerializeField]
	private TMP_Text _nicknameLabel; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _expLabel; //Field offset: 0x88
	[SerializeField]
	private Button _inspectButton; //Field offset: 0x90
	[SerializeField]
	private Image _prestigeImage; //Field offset: 0x98
	[SerializeField]
	private Image _memberImage; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _playerInfoRow; //Field offset: 0xA8
	[SerializeField]
	private GameObject _playerOwnerLabel; //Field offset: 0xB0
	[SerializeField]
	private GameObject _playerOwnerLine; //Field offset: 0xB8
	[SerializeField]
	private GameObject[] _hoverObjects; //Field offset: 0xC0
	[SerializeField]
	private Image[] _backgrounds; //Field offset: 0xC8
	[SerializeField]
	private Color _ownerColor; //Field offset: 0xD0
	[SerializeField]
	private Color _rankUpColor; //Field offset: 0xE0
	[SerializeField]
	private Color _rankStayColor; //Field offset: 0xF0
	[SerializeField]
	private Color _rankDownColor; //Field offset: 0x100
	[SerializeField]
	private Color _rankUpLabelColor; //Field offset: 0x110
	[SerializeField]
	private Color _rankStayLabelColor; //Field offset: 0x120
	[SerializeField]
	private Color _rankDownLabelColor; //Field offset: 0x130
	private string _aid; //Field offset: 0x140
	private Action _inspectAction; //Field offset: 0x148

	public SeasonsLeaderboardView() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	[AsyncStateMachine(typeof(<<SetupPlayer>g__RebuildLayout|23_0>d))]
	[CompilerGenerated]
	private Task <SetupPlayer>g__RebuildLayout|23_0() { }

	private void Awake() { }

	private void OnDestroy() { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void SetInspectButtonInteractable(bool interactable) { }

	public void SetupPlayer(int place, string nickname, string aid, EMemberCategory category, int prestige, long exp, bool owner, int changeRank, Action inspectAction, EGameMode prestigeGameMode = 0) { }

	private void ValidateColor(bool owner, int changeRank) { }

}

