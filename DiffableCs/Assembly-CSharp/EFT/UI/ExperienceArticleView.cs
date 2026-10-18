namespace EFT.UI;

public sealed class ExperienceArticleView : UIElement
{
	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _value; //Field offset: 0x78

	public ExperienceArticleView() { }

	public void Show(ExperienceArticle article) { }

}

