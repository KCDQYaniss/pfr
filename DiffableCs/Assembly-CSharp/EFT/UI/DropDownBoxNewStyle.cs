namespace EFT.UI;

[UsedImplicitly]
public class DropDownBoxNewStyle : BaseDropDownBox
{
	[SerializeField]
	private List _labels; //Field offset: 0xF0
	[SerializeField]
	private RectTransform _listContainer; //Field offset: 0xF8
	[SerializeField]
	private DefaultUiButtonNewStyle _mainButton; //Field offset: 0x100
	[SerializeField]
	private GameObject _upArrows; //Field offset: 0x108
	[SerializeField]
	private GameObject _downArrows; //Field offset: 0x110

	public DropDownBoxNewStyle() { }

	[CompilerGenerated]
	private void <Show>b__5_0() { }

	protected virtual void SetPanelState(bool open) { }

	protected virtual void SetTextInternal(string text) { }

	public virtual void Show(IEnumerable values, Func validator = null) { }

}

