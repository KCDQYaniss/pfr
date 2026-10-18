namespace EFT.UI;

public sealed class TabWithValidationColors : Tab
{
	[SerializeField]
	private Image _normalImage; //Field offset: 0x90
	[SerializeField]
	private Image _selectedImage; //Field offset: 0x98
	[SerializeField]
	private Sprite _positiveSelected; //Field offset: 0xA0
	[SerializeField]
	private Sprite _positiveIdle; //Field offset: 0xA8
	[SerializeField]
	private Sprite _negativeSelected; //Field offset: 0xB0
	[SerializeField]
	private Sprite _negativeIdle; //Field offset: 0xB8
	private bool _isValid; //Field offset: 0xC0

	public TabWithValidationColors() { }

	public virtual void Init(ITabController controller) { }

	public void SetValidationColor(bool active) { }

	protected virtual void UpdateVisual(bool selected, bool uiOnly = false) { }

}

