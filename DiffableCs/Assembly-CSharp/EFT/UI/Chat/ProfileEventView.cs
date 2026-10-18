namespace EFT.UI.Chat;

public class ProfileEventView : UIElement
{
	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x70
	[SerializeField]
	private DefaultUIButton _applyButton; //Field offset: 0x78
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x80
	public BindableEvent OnRedeem; //Field offset: 0x88
	private ProfileChangeEvent _profileEvent; //Field offset: 0x90

	public ProfileEventView() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	private void ApplyEvent() { }

	public void Show(ProfileChangeEvent profileEvent) { }

	private void UpdateEvent() { }

}

