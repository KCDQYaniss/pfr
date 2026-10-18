namespace EFT.WeaponMounting.Debug.View.Pages;

public class MountingStartPage : IMountingPage
{
	private readonly MountingPageViewer _pageViewer; //Field offset: 0x10
	private bool _buttonShowGridOptions; //Field offset: 0x18
	private bool _buttonShowRecoilOptions; //Field offset: 0x19

	public MountingStartPage(MountingPageViewer pageViewer) { }

	private void CheckEvents() { }

	private GUIStyle GetButtonStyle() { }

	public override void Update() { }

}

