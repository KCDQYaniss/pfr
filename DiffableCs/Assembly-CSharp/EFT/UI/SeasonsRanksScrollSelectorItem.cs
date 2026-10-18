namespace EFT.UI;

public class SeasonsRanksScrollSelectorItem : MonoBehaviour
{
	[SerializeField]
	private Button _button; //Field offset: 0x20
	[SerializeField]
	private Image _image; //Field offset: 0x28
	private int _index; //Field offset: 0x30
	private Action _clickAction; //Field offset: 0x38

	public SeasonsRanksScrollSelectorItem() { }

	[CompilerGenerated]
	private void <Start>b__4_0() { }

	public void Init(int index, Action clickAction, Sprite sprite) { }

	private void Start() { }

}

