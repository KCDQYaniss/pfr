namespace EFT.UI;

public sealed class ExperienceSectionView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Show>b__6_0(ExperienceArticle article, ExperienceArticleView view) { }

	}

	[SerializeField]
	private CustomTextMeshProUGUI _caption; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _value; //Field offset: 0x78
	[SerializeField]
	private Image _icon; //Field offset: 0x80
	[SerializeField]
	[Space]
	private Transform _articlesContainer; //Field offset: 0x88
	[SerializeField]
	private ExperienceArticleView _articleTemplate; //Field offset: 0x90
	[SerializeField]
	private PlayerExperienceIcon _expIcon; //Field offset: 0x98

	public ExperienceSectionView() { }

	public void Show(ExperienceSection section) { }

}

