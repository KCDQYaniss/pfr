namespace EFT.UI;

public class LocalizationButtonCap : UIElement
{
	[SerializeField]
	private UIAnimatedToggleSpawner _toggleSpawner; //Field offset: 0x70
	[SerializeField]
	private GameObject _loader; //Field offset: 0x78
	private Action _onClick; //Field offset: 0x80
	[CompilerGenerated]
	private CanvasGroup <CanvasGroup>k__BackingField; //Field offset: 0x88

	public private CanvasGroup CanvasGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public LocalizationButtonCap() { }

	private void Awake() { }

	[CompilerGenerated]
	public CanvasGroup get_CanvasGroup() { }

	private void OnClickHandler(bool value) { }

	[CompilerGenerated]
	private void set_CanvasGroup(CanvasGroup value) { }

	public void SetLoadedStatus(string text, bool value) { }

	public void SetToggle(bool value) { }

	public void Show(Action onClick) { }

}

