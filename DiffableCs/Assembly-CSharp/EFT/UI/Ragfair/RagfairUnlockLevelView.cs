namespace EFT.UI.Ragfair;

public class RagfairUnlockLevelView : MonoBehaviour
{
	[SerializeField]
	protected TextMeshProUGUI _lockByLevelValue; //Field offset: 0x20
	[SerializeField]
	protected Image _icon; //Field offset: 0x28
	[SerializeField]
	protected HoverTooltipArea _tooltip; //Field offset: 0x30
	private Nullable _labelColor; //Field offset: 0x38
	private Nullable _iconColor; //Field offset: 0x4C

	public RagfairUnlockLevelView() { }

	public void Deselect() { }

	public void Select() { }

	public void SetLockByLevel(bool locked, int level = 0) { }

}

