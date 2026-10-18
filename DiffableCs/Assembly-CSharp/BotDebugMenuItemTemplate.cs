//Type is in global namespace

public class BotDebugMenuItemTemplate : MonoBehaviour
{
	public TMP_Text ItemLabel; //Field offset: 0x20
	public TMP_Text HintText; //Field offset: 0x28
	[SerializeField]
	private GameObject _selector; //Field offset: 0x30
	[SerializeField]
	private GameObject _leftArrow; //Field offset: 0x38
	[SerializeField]
	private GameObject _rightArrow; //Field offset: 0x40
	[SerializeField]
	private GameObject _hintRoot; //Field offset: 0x48

	public BotDebugMenuItemTemplate() { }

	public void ChangeSelection(bool selected) { }

	public void SetArrowsVisible(bool left, bool right) { }

	public void SetHitActive(bool active) { }

}

