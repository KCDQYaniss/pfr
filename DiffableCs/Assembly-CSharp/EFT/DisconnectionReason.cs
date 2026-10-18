namespace EFT;

public struct DisconnectionReason
{
	public EDisconnectionCode DisconnectionCode; //Field offset: 0x0
	public string AdditionalInfo; //Field offset: 0x8
	public string OriginalTechnicalMessage; //Field offset: 0x10

	public virtual string ToString() { }

}

