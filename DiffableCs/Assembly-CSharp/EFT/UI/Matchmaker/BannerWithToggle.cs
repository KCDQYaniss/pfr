namespace EFT.UI.Matchmaker;

public sealed class BannerWithToggle
{
	public readonly MatchmakerBanner Banner; //Field offset: 0x10
	public readonly BannerPageToggle Toggle; //Field offset: 0x18

	public BannerWithToggle(MatchmakerBanner banner, BannerPageToggle toggle) { }

}

