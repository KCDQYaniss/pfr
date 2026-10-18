namespace EFT.DataProviding;

public sealed class DataProvider
{
	private static DataProvider _instance; //Field offset: 0x0
	private readonly TypesDictionary _permanentData; //Field offset: 0x10
	private readonly Dictionary _idToType; //Field offset: 0x18
	private readonly Dictionary _typeToId; //Field offset: 0x20
	private readonly Dictionary _typeToLifeTime; //Field offset: 0x28
	private readonly Dictionary _dataByLifeTime; //Field offset: 0x30
	private readonly Dictionary _syncDataContainers; //Field offset: 0x38
	private int _packetId; //Field offset: 0x40

	public ValueCollection AllInitedData
	{
		 get { } //Length: 97
	}

	public bool HasDataToTransfer
	{
		 get { } //Length: 801
	}

	public static DataProvider Instance
	{
		 get { } //Length: 190
	}

	private DataProvider() { }

	public static bool CreateData(EDataLifeTime dataLifeTime) { }

	private bool CreateData(Type type, EDataLifeTime dataLifeTime) { }

	public void Deserialize(IBitReaderStream readerStream, int sourcePlayerRaidId) { }

	public void Dispose() { }

	private void FillTypeIdDict() { }

	public ValueCollection get_AllInitedData() { }

	public bool get_HasDataToTransfer() { }

	public static DataProvider get_Instance() { }

	public static T GetData() { }

	private List GetDataContainersTypes() { }

	public void Serialize(ref IBitWriterStream writerStream, bool isFullUpdate = false) { }

	public static bool TryGetData(out T dataContainer) { }

	public static bool TryGetData(Type containerType, out IDataContainer dataContainer) { }

}

