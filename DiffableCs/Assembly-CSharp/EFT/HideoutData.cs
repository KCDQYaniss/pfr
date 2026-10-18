namespace EFT;

public sealed class HideoutData
{
	public readonly Dictionary AreasStashes; //Field offset: 0x10
	public readonly CompoundItem CustomizationStash; //Field offset: 0x18
	public readonly HideoutInfo Info; //Field offset: 0x20
	public readonly bool IsGuest; //Field offset: 0x28
	public readonly string OwnerName; //Field offset: 0x30
	public readonly string OwnerAccountId; //Field offset: 0x38

	public HideoutData(HideoutInfo info, Dictionary areasStashes, CompoundItem customizationStash, bool isGuest, string ownerAccountId, string ownerName = "") { }

}

