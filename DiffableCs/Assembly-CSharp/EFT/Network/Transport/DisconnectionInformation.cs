namespace EFT.Network.Transport;

public struct DisconnectionInformation
{
	public string Address; //Field offset: 0x0
	public int Port; //Field offset: 0x8
	public SystemReasonDisconnection Reason; //Field offset: 0xC

}

