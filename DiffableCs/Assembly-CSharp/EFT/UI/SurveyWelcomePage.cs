namespace EFT.UI;

public sealed class SurveyWelcomePage : SurveyPage
{
	[SerializeField]
	private TMP_Text _title; //Field offset: 0x90
	[SerializeField]
	private TMP_Text _time; //Field offset: 0x98
	[SerializeField]
	private TMP_Text _description; //Field offset: 0xA0

	public SurveyWelcomePage() { }

	public virtual void Show(WelcomePageData data) { }

}

