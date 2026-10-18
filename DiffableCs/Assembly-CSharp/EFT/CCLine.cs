namespace EFT;

[IsReadOnly]
public struct CCLine
{
	[JsonProperty("t")]
	public readonly string Text; //Field offset: 0x0
	[JsonProperty("s")]
	public readonly double StartTime; //Field offset: 0x8
	[JsonProperty("e")]
	public readonly double EndTime; //Field offset: 0x10

	public CCLine(string text, double startTime, double endTime) { }

}

