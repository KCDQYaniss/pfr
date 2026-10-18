//Type is in global namespace

public class DebugPanelHeaths : MonoBehaviour
{
	public Image IconsHealthHead; //Field offset: 0x20
	public Image IconsHealthBody; //Field offset: 0x28
	public Image IconsHealthStomach; //Field offset: 0x30
	public Image IconsHealthLeftArm; //Field offset: 0x38
	public Image IconsHealthRightArm; //Field offset: 0x40
	public Image IconsHealthLeftLeg; //Field offset: 0x48
	public Image IconsHealthRightLeg; //Field offset: 0x50
	private RectTransform _rectTransf; //Field offset: 0x58

	public RectTransform RectTransform
	{
		 get { } //Length: 176
	}

	public DebugPanelHeaths() { }

	public RectTransform get_RectTransform() { }

	public Color GetHealthColor(int currentHealth, int maxHealth) { }

	public void UpdateHealth(DebugHeathsDataStructInner heathsData) { }

}

