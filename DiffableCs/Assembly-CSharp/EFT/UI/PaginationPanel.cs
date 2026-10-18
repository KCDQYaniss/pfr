namespace EFT.UI;

[UsedImplicitly]
public sealed class PaginationPanel : SerializedMonoBehaviour
{
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public Button FirstPageButton; //Field offset: 0x60
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public Button LastPageButton; //Field offset: 0x68
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public Button PreviousPageButton; //Field offset: 0x70
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public Button NextPageButton; //Field offset: 0x78
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public PageButton PageButtonTemplate; //Field offset: 0x80
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public Transform PageButtonsRoot; //Field offset: 0x88
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	public int PageButtonsCount; //Field offset: 0x90

	public PaginationPanel() { }

}

