namespace EFT.UI.Screens;

public abstract class EftMatchmakerScreenController`2 : EftSequenceScreenController
{
	private static readonly EEftScreenType[] MATCHMAKER_SCREENS; //Field offset: 0x0
	public readonly MatchmakerPlayersController MatchmakerPlayersController; //Field offset: 0x0
	public readonly EGameMode gameMode; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnShowReadyScreen; //Field offset: 0x0

	public event Action OnShowReadyScreen
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	protected virtual EStateSwitcher TaskBarButtonsAvailability
	{
		 get { } //Length: 6
	}

	private static EftMatchmakerScreenController`2() { }

	protected EftMatchmakerScreenController`2(MatchmakerPlayersController matchmakerPlayersController, EGameMode gameMode) { }

	[CompilerGenerated]
	public void add_OnShowReadyScreen(Action value) { }

	protected virtual void CloseAction(bool moveForward) { }

	private void ExitFromMatchmaker() { }

	protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	[CompilerGenerated]
	public void remove_OnShowReadyScreen(Action value) { }

	internal void ShowReadyScreen() { }

}

