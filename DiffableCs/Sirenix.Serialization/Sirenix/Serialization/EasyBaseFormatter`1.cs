namespace Sirenix.Serialization;

public abstract class EasyBaseFormatter`1 : BaseFormatter
{

	protected EasyBaseFormatter`1() { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	protected abstract void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader) { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

	protected abstract void WriteDataEntries(ref T value, IDataWriter writer) { }

}

