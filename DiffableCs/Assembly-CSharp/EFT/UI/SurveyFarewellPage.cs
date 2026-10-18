namespace EFT.UI;

public sealed class SurveyFarewellPage : SurveyPage
{
	[SerializeField]
	private TMP_Text _text; //Field offset: 0x90

	public SurveyFarewellPage() { }

	public virtual void Show(FarewellPageData data) { }

}

