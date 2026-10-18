namespace EFT.UI;

public sealed class RewardDetailsActionState : IDisposable
{
	private readonly ItemContext _itemContext; //Field offset: 0x10
	private readonly VoicePreviewSpeaker _voicePreviewSpeaker; //Field offset: 0x18
	private readonly string _soundToPlay; //Field offset: 0x20
	private readonly CustomizationSuite _suiteToShow; //Field offset: 0x28
	private readonly PrestigeReward _reward; //Field offset: 0x30

	public bool HasAnimationAction
	{
		 get { } //Length: 3
	}

	public bool HasCraftAction
	{
		 get { } //Length: 30
	}

	public bool HasItemInfoAction
	{
		 get { } //Length: 19
	}

	public bool HasSoundAction
	{
		 get { } //Length: 28
	}

	public bool HasTradingOfferAction
	{
		 get { } //Length: 36
	}

	public bool HasUnmetTradingOfferLoyalty
	{
		 get { } //Length: 440
	}

	public RewardDetailsActionState(PrestigeReward reward) { }

	public bool CanExecute() { }

	public override void Dispose() { }

	public void ExecuteAction() { }

	public bool get_HasAnimationAction() { }

	public bool get_HasCraftAction() { }

	public bool get_HasItemInfoAction() { }

	public bool get_HasSoundAction() { }

	public bool get_HasTradingOfferAction() { }

	public bool get_HasUnmetTradingOfferLoyalty() { }

	public void PlayAnimation() { }

	public void PlaySound() { }

	public void SetupCraftTooltip(HoverTooltipArea tooltipArea) { }

	public void SetupTradingOfferTooltip(TradingOfferTooltipArea tooltipArea) { }

	public void ShowItemInfo() { }

}

