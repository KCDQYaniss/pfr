namespace EFT.Vaulting.Debug.Controller.PageControllers;

public class VaultingRestrictionsPageController : IVaultingDebugPageController
{
	private readonly IVaultingRestrictionsModelDebug _vaultingRestrictionsModel; //Field offset: 0x10
	private readonly RestrictionsPageView _view; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnVaultingRestrictionsUpdated; //Field offset: 0x28

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnVaultingRestrictionsUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public VaultingRestrictionsPageController(IVaultingRestrictionsModelDebug model, RestrictionsPageView view) { }

	[CompilerGenerated]
	private void <Subscribe>b__10_0() { }

	[CompilerGenerated]
	private void <Unsubscribe>b__11_0() { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnVaultingRestrictionsUpdated(Action value) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnVaultingRestrictionsUpdated(Action value) { }

	public override void SetAsCurrent() { }

	private void SetVaultingRestrictions() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	private void UpdateVaultingRestrictionsModel() { }

}

