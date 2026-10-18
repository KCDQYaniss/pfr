namespace Koenigz.PerfectCulling.EFT;

[RequireComponent(typeof(ScreenDistanceSwitcher))]
public sealed class BakedLodContent : PerfectCullingCrossSceneContent
{
	[SerializeField]
	private ScreenDistanceSwitcher _screenDistanceSwitcher; //Field offset: 0x40

	public ScreenDistanceSwitcher Switcher
	{
		 get { } //Length: 5
	}

	public BakedLodContent() { }

	public ScreenDistanceSwitcher get_Switcher() { }

	public virtual void OnBakedLODVisbilityChanged(ScreenDistanceSwitcher bakeLOD, bool isVisible) { }

}

