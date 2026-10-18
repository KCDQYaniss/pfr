namespace System.Text.Unicode;

public sealed class UnicodeRange
{
	[CompilerGenerated]
	private int <FirstCodePoint>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0x14

	public private int FirstCodePoint
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int Length
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public UnicodeRange(int firstCodePoint, int length) { }

	[NullableContext(1)]
	public static UnicodeRange Create(char firstCharacter, char lastCharacter) { }

	[CompilerGenerated]
	public int get_FirstCodePoint() { }

	[CompilerGenerated]
	public int get_Length() { }

	[CompilerGenerated]
	private void set_FirstCodePoint(int value) { }

	[CompilerGenerated]
	private void set_Length(int value) { }

}

