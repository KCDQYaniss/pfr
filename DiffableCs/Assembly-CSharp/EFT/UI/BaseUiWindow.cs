namespace EFT.UI;

public abstract class BaseUiWindow : UIElement
{
	[SerializeField]
	private GameObject _captionPanel; //Field offset: 0x70
	[SerializeField]
	private Button _closeButton; //Field offset: 0x78

	public bool IsActive
	{
		 get { } //Length: 156
	}

	protected BaseUiWindow() { }

	protected override void Awake() { }

	public bool get_IsActive() { }

}

