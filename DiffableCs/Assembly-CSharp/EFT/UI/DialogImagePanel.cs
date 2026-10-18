namespace EFT.UI;

public sealed class DialogImagePanel : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public MediaAnimationController controller; //Field offset: 0x10
		public DialogImagePanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <Show>b__0() { }

	}

	[SerializeField]
	private Image _image; //Field offset: 0x70
	private IImageLoader _imageLoader; //Field offset: 0x78

	public DialogImagePanel() { }

	private void OnSpriteChanged(string imagePath) { }

	public void Show(IImageLoader loader, MediaAnimationController controller) { }

}

