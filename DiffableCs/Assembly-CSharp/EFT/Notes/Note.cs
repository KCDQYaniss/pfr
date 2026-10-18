namespace EFT.Notes;

[GenerateBinarySerialization]
public sealed class Note
{
	public const int TEXT_CHARACTER_LIMIT = 1024; //Field offset: 0x0
	public const int NOTES_LIMIT = 50; //Field offset: 0x0
	[JsonProperty("Time")]
	public float Time; //Field offset: 0x10
	[JsonProperty("Text")]
	public string Text; //Field offset: 0x18

	public Note() { }

	public void CopyFields(Note note) { }

}

