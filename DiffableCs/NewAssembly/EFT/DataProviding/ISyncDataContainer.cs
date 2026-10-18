namespace EFT.DataProviding;

public interface ISyncDataContainer : IDataContainer
{

	[JsonIgnore]
	public bool IsUpdated
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void Deserialize(ref IBitReaderStream readerStream, int sourcePlayerRaideId) { }

	public bool get_IsUpdated() { }

	public void Serialize(ref IBitWriterStream writerStream, bool isFullUpdate = false) { }

	public void set_IsUpdated(bool value) { }

}

