namespace EFT.DataProviding;

public class DataProviderSynchronizationClient
{
	private static DataProviderSynchronizationClient _dataProviderSynchronizationClient; //Field offset: 0x0
	private IBitWriterStream _packetStream; //Field offset: 0x10
	private ArraySegment _packet; //Field offset: 0x18
	private ClientPlayer _clientPlayer; //Field offset: 0x28

	private DataProviderSynchronizationClient(ClientPlayer clientPlayer) { }

	private ArraySegment CreatePacket(bool fullData) { }

	private void Dispose() { }

	public static void Initialize(ClientPlayer clientPlayer) { }

	private void OnUpdate() { }

}

