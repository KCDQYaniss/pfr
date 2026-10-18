namespace EFT.UI.Matchmaker;

public class MatchMakerGroupPreview : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetAndPlaceView>b__10_0(ComradePlacedView p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public MatchMakerPlayerPreview view; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <CloseView>b__0(ComradePlacedView comradeView) { }

	}

	private class ComradePlacedView
	{
		public ComradeView PlaceHolder; //Field offset: 0x10
		public MatchMakerPlayerPreview View; //Field offset: 0x18

		public ComradePlacedView() { }

	}

	[SerializeField]
	private List _comradeViewHolderPositions; //Field offset: 0x70
	[SerializeField]
	private MatchMakerPlayerPreview _playerPreviewTemplate; //Field offset: 0x78
	private string _profileAid; //Field offset: 0x80
	private MatchmakerPlayersController _matchmakerPlayersController; //Field offset: 0x88
	private Dictionary _viewsCache; //Field offset: 0x90
	private Func _interactionsFactory; //Field offset: 0x98
	private RaidSettings _raidSettings; //Field offset: 0xA0

	public MatchMakerGroupPreview() { }

	[CompilerGenerated]
	private bool <UpdateGroup>b__9_0(RaidPlayer player) { }

	public virtual void Close() { }

	private void CloseView(MatchMakerPlayerPreview view) { }

	private MatchMakerPlayerPreview GetAndPlaceView(string playerAId, out ComradePlacedView placePosition) { }

	public void Show(string mainProfileAid, MatchmakerPlayersController matchmakerPlayersController, RaidSettings raidSettings, Func interactionsFactory) { }

	private void UpdateGroup() { }

}

