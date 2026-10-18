namespace EFT;

public sealed class QuestionTemplate
{
	internal enum EAnswerType
	{
		SingleOption = 0,
		MultiOption = 1,
		Text = 2,
	}

	[JsonProperty("id")]
	public int id; //Field offset: 0x10
	[JsonProperty("sort")]
	public int sortIndex; //Field offset: 0x14
	[JsonProperty("titleLocaleKey")]
	public string titleLocaleKey; //Field offset: 0x18
	[JsonProperty("hintLocaleKey")]
	public string hintLocaleKey; //Field offset: 0x20
	[JsonProperty("answerLimit")]
	public int answersLimit; //Field offset: 0x28
	[JsonProperty("answerType")]
	public EAnswerType answerType; //Field offset: 0x2C
	[JsonProperty("answers")]
	public AnswerTemplate[] answers; //Field offset: 0x30

	public QuestionTemplate() { }

}

