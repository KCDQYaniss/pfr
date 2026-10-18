namespace EFT.Airdrop;

public interface IAirdropDataSender
{

	public void SendAirdropContainerData(EAirdropType containerType, Item item, int ObjectId) { }

	public void SendFlareSuccessEvent(string profileId, bool canSendAirdrop) { }

}

