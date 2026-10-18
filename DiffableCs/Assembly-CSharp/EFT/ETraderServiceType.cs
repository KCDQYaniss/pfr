namespace EFT;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.ETraderServiceType>))]
public enum ETraderServiceType
{
	None = -1,
	ExUsecLoyalty = 0,
	ZryachiyAid = 1,
	CultistsAid = 2,
	BtrItemsDelivery = 3,
	PlayerTaxi = 4,
	BtrBotCover = 5,
	TransitItemsDelivery = 6,
	StoryCardBarter = 7,
}

