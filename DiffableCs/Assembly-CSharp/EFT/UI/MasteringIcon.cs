namespace EFT.UI;

public sealed class MasteringIcon : ItemIconView
{
	[SerializeField]
	private CustomTextMeshProUGUI _progress; //Field offset: 0xA8
	[SerializeField]
	private Image _levelUpGlow; //Field offset: 0xB0
	[SerializeField]
	private GameObject _mastering; //Field offset: 0xB8
	[SerializeField]
	private CustomTextMeshProUGUI _masteringText; //Field offset: 0xC0

	public MasteringIcon() { }

	protected virtual void OnHoverEnd(PointerEventData eventData) { }

	public void Show(KeyValuePair masteringSkill, Action onHover) { }

	public void UpdateProgress(Mastering mastering) { }

}

