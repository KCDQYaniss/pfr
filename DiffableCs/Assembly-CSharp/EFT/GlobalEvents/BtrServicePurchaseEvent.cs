namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public sealed class BtrServicePurchaseEvent : SyncEventFromServer
{
	public int[] PlayerRaidIds; //Field offset: 0x18
	public ETraderServiceType ServiceType; //Field offset: 0x20

	public BtrServicePurchaseEvent() { }

	public virtual void Deserialize(ref IBitReaderStream readerStream) { }

	public void Invoke(int[] playerIds, ETraderServiceType serviceType) { }

	public virtual void Reset() { }

	public virtual void Serialize(ref IBitWriterStream writerStream) { }

}

