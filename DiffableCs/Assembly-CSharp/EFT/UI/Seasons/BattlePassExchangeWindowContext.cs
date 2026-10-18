namespace EFT.UI.Seasons;

public sealed class BattlePassExchangeWindowContext : BaseWindowContext
{
	private BattlePassExchangeWindow _window; //Field offset: 0x68

	public BattlePassExchangeWindowContext() { }

	public void Accept(BattlePassDocumentExchangeSelection selection) { }

	public void Bind(BattlePassExchangeWindow window) { }

	public void ResetAfterExchange() { }

	public void SetOperationInProgress(bool state) { }

}

