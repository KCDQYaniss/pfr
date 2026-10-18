namespace EFT.UI.Ragfair;

public sealed class OfferIdContextInteractions : ContextInteractions
{
	internal enum EOfferIdContextInteraction
	{
		CopyId = 0,
		PasteId = 1,
		ReportOffer = 2,
	}

	private static readonly Dictionary _customNames; //Field offset: 0x0
	private readonly Action _closeAction; //Field offset: 0x38
	[CanBeNull]
	private readonly Action _pasteAction; //Field offset: 0x40
	[CanBeNull]
	private readonly RagFair _ragfair; //Field offset: 0x48
	[CanBeNull]
	private readonly Offer _offer; //Field offset: 0x50

	public virtual Dictionary CustomNames
	{
		 get { } //Length: 83
	}

	public virtual bool HasIcons
	{
		 get { } //Length: 3
	}

	private static OfferIdContextInteractions() { }

	public OfferIdContextInteractions(Action closeAction, Offer offer = null, RagFair ragfair = null, Action pasteAction = null) { }

	private void CopyId() { }

	protected virtual void ExecuteInteractionInternal(EOfferIdContextInteraction interaction) { }

	public virtual Dictionary get_CustomNames() { }

	public virtual bool get_HasIcons() { }

	private void HandleFailedResultAsWarning(IResult result) { }

	public virtual bool IsActive(EOfferIdContextInteraction button) { }

	public virtual IResult IsInteractive(EOfferIdContextInteraction button) { }

	private void PasteId() { }

	private void ReportOffer() { }

}

