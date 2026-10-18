namespace Sirenix.Serialization;

public class EmptyTypeFormatter`1 : EasyBaseFormatter
{

	public EmptyTypeFormatter`1() { }

	protected virtual void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader) { }

	protected virtual void WriteDataEntries(ref T value, IDataWriter writer) { }

}

