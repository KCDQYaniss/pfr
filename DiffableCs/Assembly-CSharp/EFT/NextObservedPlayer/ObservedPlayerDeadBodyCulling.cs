namespace EFT.NextObservedPlayer;

public class ObservedPlayerDeadBodyCulling : IDisposable
{
	private ObservedPlayerView _view; //Field offset: 0x10
	private ObservedCullingObject _cullingObject; //Field offset: 0x18
	private ObservedCorpse _corpse; //Field offset: 0x20
	private ObservedPlayerHandsController _handsController; //Field offset: 0x28
	private bool _isFinallySynced; //Field offset: 0x30
	private List _rendereredCahche; //Field offset: 0x38
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0x40
	private bool _isVisibleNextState; //Field offset: 0x41

	public bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ObservedPlayerDeadBodyCulling(ObservedPlayerView view, ObservedCorpse corpse, ObservedPlayerHandsController handsController) { }

	private void ApplyVisibleState() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_IsVisible() { }

	public void ManulUpdate(float dt) { }

	private void OnUnequipWeaponFromDeadBody() { }

	private void OnVisibilityChanged(bool value) { }

	[CompilerGenerated]
	public void set_IsVisible(bool value) { }

}

