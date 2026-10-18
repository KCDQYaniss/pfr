namespace EFT;

public sealed class SurveyTemplate
{
	[JsonProperty("id")]
	public int id; //Field offset: 0x10
	[JsonProperty("isNew")]
	public bool isNew; //Field offset: 0x14
	[JsonProperty("welcomePageData")]
	public WelcomePageData welcomePageData; //Field offset: 0x18
	[JsonProperty("farewellPageData")]
	public FarewellPageData farewellPageData; //Field offset: 0x30
	[JsonProperty("pages")]
	public List pageQuestionsPresenceData; //Field offset: 0x38
	[JsonProperty("questions")]
	public QuestionTemplate[] questions; //Field offset: 0x40

	public SurveyTemplate() { }

}

