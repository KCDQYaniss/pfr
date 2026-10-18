namespace EFT.UI.DragAndDrop;

[UsedImplicitly]
public class ItemViewBottomPanel : MonoBehaviour
{
	[SerializeField]
	public QuestItemViewPanel QuestsItemViewPanel; //Field offset: 0x20
	[SerializeField]
	public GameObject InsuredIcon; //Field offset: 0x28
	[SerializeField]
	public Image RepairBuffIcon; //Field offset: 0x30
	[SerializeField]
	public HoverTrigger HoverTrigger; //Field offset: 0x38
	[SerializeField]
	public ItemViewStats ItemViewStats; //Field offset: 0x40
	[SerializeField]
	public TextMeshProUGUI ItemInscription; //Field offset: 0x48
	[SerializeField]
	public TextMeshProUGUI ItemValue; //Field offset: 0x50
	[SerializeField]
	public PointerEventsProxy ValuePointerEventsProxy; //Field offset: 0x58
	[SerializeField]
	public GameObject AlphaFakeObject; //Field offset: 0x60

	public ItemViewBottomPanel() { }

}

