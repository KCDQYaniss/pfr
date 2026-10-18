namespace EFT.Vaulting.Debug.Controller;

public class GridOptionsPageController : IVaultingDebugPageController
{
	private readonly IGridSettingsModelDebug _gridModel; //Field offset: 0x10
	private readonly GridOptionsPageView _gridOptionsPageView; //Field offset: 0x18
	private readonly GridPointsController _gridCalculatorController; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnClickBackButton; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnGridModelUpdated; //Field offset: 0x30

	public event Action OnClickBackButton
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnGridModelUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public GridOptionsPageController(GridOptionsPageView gridOptionsPageView, IGridSettingsModelDebug gridModel, GridPointsController coreGridController) { }

	[CompilerGenerated]
	private void <Subscribe>b__11_0() { }

	[CompilerGenerated]
	private void <Unsubscribe>b__12_0() { }

	[CompilerGenerated]
	public void add_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void add_OnGridModelUpdated(Action value) { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public void remove_OnClickBackButton(Action value) { }

	[CompilerGenerated]
	public void remove_OnGridModelUpdated(Action value) { }

	public override void SetAsCurrent() { }

	private void SetInitialParameters() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	private void UpdateGridModel() { }

}

