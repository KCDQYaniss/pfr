namespace EFT.SeasonBP;

public sealed class BattlePass : IDisposable
{
	private readonly BindableEvent _onRewardClaimed; //Field offset: 0x10
	public readonly MongoID Id; //Field offset: 0x18
	public readonly int ExchangeRateDocuments; //Field offset: 0x30
	public readonly IReadOnlyList Documents; //Field offset: 0x38
	public readonly BattlePassItemExchangeSettings ItemExchangeSettings; //Field offset: 0x40
	public readonly BattlePassDocumentLimitSettings DocumentLimits; //Field offset: 0x48
	private readonly List _pages; //Field offset: 0x50
	public readonly BattlePassDocumentLimitData Limit; //Field offset: 0x58
	private readonly CompositeDisposable _unsubscriber; //Field offset: 0x60

	public IBindableEvent OnRewardClaimed
	{
		 get { } //Length: 5
	}

	public IReadOnlyList Pages
	{
		 get { } //Length: 5
	}

	public BattlePass(BattlePassData template, BattlePassProgressData progressData, BattlePassDocumentLimitData limit) { }

	public override void Dispose() { }

	public IBindableEvent get_OnRewardClaimed() { }

	public IReadOnlyList get_Pages() { }

}

