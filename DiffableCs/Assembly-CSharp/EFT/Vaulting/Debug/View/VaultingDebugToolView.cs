namespace EFT.Vaulting.Debug.View;

public class VaultingDebugToolView : MonoBehaviour
{
	private PageViewer _pageViewer; //Field offset: 0x20

	public PageViewer PageViewer
	{
		 get { } //Length: 5
	}

	public VaultingDebugToolView() { }

	public PageViewer get_PageViewer() { }

	private void OnDestroy() { }

	private void OnEnable() { }

}

