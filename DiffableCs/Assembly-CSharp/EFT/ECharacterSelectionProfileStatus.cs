namespace EFT;

[JsonConverter(typeof(EFT.EnumConverter`1<EFT.ECharacterSelectionProfileStatus>))]
public enum ECharacterSelectionProfileStatus
{
	Locked = 0,
	Empty = 1,
	Available = 2,
	InRaid = 3,
	AvailableForPurchase = 4,
}

