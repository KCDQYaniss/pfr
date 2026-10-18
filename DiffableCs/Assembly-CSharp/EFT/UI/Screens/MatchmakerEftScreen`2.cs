namespace EFT.UI.Screens;

public abstract class MatchmakerEftScreen`2 : EftScreen
{
	[SerializeField]
	private TextMeshProUGUI _subCaption; //Field offset: 0x0
	protected MatchmakerPlayersController MatchmakerPlayersController; //Field offset: 0x0

	protected MatchmakerEftScreen`2() { }

	[CompilerGenerated]
	private void <Show>b__2_0() { }

	private void HandleProcessingReady(bool isProcessingReady) { }

	protected override void InviteAcceptedHandler() { }

	protected override void MatchingTypeUpdateHandler(EMatchingType matchingType) { }

	public virtual void Show(TController controller) { }

}

