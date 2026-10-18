namespace UI.BattleUI;

public class TutorialHintLineView : MonoBehaviour
{
	private const string DOUBLE_CLICK = "double_click"; //Field offset: 0x0
	private const string CUSTOM = "custom"; //Field offset: 0x0
	private const string CUSTOM_SEPARATOR = "_"; //Field offset: 0x0
	[SerializeField]
	private TMP_Text _label; //Field offset: 0x20
	[SerializeField]
	private RectTransform _contentRoot; //Field offset: 0x28
	[SerializeField]
	private KeyView _keyViewTemplate; //Field offset: 0x30
	[SerializeField]
	private KeyViewContentGenerator _keyViewContentGenerator; //Field offset: 0x38
	private List _keyViewInstances; //Field offset: 0x40

	public TutorialHintLineView() { }

	private void ClearInstances() { }

	private KeyBinding GetLineKeyBinding(TutorialHintLine line) { }

	public void SetLine(TutorialHintLine data) { }

	private bool TryGetCustomKeyButtons(string input, out KeyBinding result) { }

	private void ValidateKeyBindings(TutorialHintLine data) { }

	public void ValidateLayout() { }

}

