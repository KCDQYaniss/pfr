namespace Sirenix.Serialization;

public class JsonTextReader : IDisposable
{
	private static readonly Dictionary EntryDelineators; //Field offset: 0x0
	private static readonly Dictionary UnescapeDictionary; //Field offset: 0x8
	private StreamReader reader; //Field offset: 0x10
	private int bufferIndex; //Field offset: 0x18
	private char[] buffer; //Field offset: 0x20
	private Nullable lastReadChar; //Field offset: 0x28
	private Nullable peekedChar; //Field offset: 0x2C
	private Queue emergencyPlayback; //Field offset: 0x30
	[CompilerGenerated]
	private DeserializationContext <Context>k__BackingField; //Field offset: 0x38

	public private DeserializationContext Context
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static JsonTextReader() { }

	public JsonTextReader(Stream stream, DeserializationContext context) { }

	private char ConsumeChar() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public DeserializationContext get_Context() { }

	private Nullable GuessPrimitiveType(string content) { }

	private bool IsHex(char c) { }

	private void ParseEntryFromBuffer(out string name, out string valueContent, out EntryType entry, int valueSeparatorIndex, Nullable hintEntry) { }

	private char ParseHexChar(char c1, char c2, char c3, char c4) { }

	private uint ParseSingleChar(char c, uint multiplier) { }

	private char PeekChar() { }

	private char ReadCharIntoBuffer() { }

	public void ReadToNextEntry(out string name, out string valueContent, out EntryType entry) { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_Context(DeserializationContext value) { }

	private void SkipChar() { }

}

