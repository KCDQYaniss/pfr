namespace EFT;

public sealed class AnswerTemplate
{
	[JsonProperty("id")]
	public int id; //Field offset: 0x10
	[JsonProperty("questionId")]
	public int questionId; //Field offset: 0x14
	[JsonProperty("sort")]
	public int sortIndex; //Field offset: 0x18
	[JsonProperty("localeKey")]
	public string localeKey; //Field offset: 0x20

	public AnswerTemplate() { }

}

