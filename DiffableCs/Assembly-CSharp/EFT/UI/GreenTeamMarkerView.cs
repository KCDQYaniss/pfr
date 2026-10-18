namespace EFT.UI;

public sealed class GreenTeamMarkerView : MonoBehaviour
{
	[SerializeField]
	private GameObject _operatorIcon; //Field offset: 0x20
	[SerializeField]
	private GameObject _candidateIcon; //Field offset: 0x28
	private Image _operatorImage; //Field offset: 0x30
	private Image _candidateImage; //Field offset: 0x38
	private bool _imagesBound; //Field offset: 0x40

	public GreenTeamMarkerView() { }

	private void Awake() { }

	private void BindImages() { }

	private static Profile GetLocalPmcProfile() { }

	public static EGreenTeamRelation ResolveLocalRelation(string otherAccountId, bool includeSelf = false) { }

	private static void SetIconVisible(GameObject icon, Image image, bool visible) { }

	public void Show(string otherAccountId, bool includeSelf = false) { }

	public void Show(string accountId, EPlayerSide side, bool includeSelf = false) { }

	public void Show(EGreenTeamRelation relation) { }

}

