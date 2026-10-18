namespace Sirenix.Serialization;

public static class FormatterEmitter
{
	[EmittedFormatter]
	internal abstract class AOTEmittedFormatter`1 : EasyBaseFormatter
	{

		protected AOTEmittedFormatter`1() { }

	}

	internal abstract class EmptyAOTEmittedFormatter`1 : AOTEmittedFormatter
	{

		protected EmptyAOTEmittedFormatter`1() { }

		protected virtual void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader) { }

		protected virtual void WriteDataEntries(ref T value, IDataWriter writer) { }

	}

	private static int helperFormatterNameId; //Field offset: 0x0
	public const string PRE_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.AOTGenerated"; //Field offset: 0x0
	public const string RUNTIME_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.RuntimeEmitted"; //Field offset: 0x0

	public static IFormatter GetEmittedFormatter(Type type, ISerializationPolicy policy) { }

}

