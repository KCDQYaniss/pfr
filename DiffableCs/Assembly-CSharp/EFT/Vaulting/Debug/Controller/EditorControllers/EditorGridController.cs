namespace EFT.Vaulting.Debug.Controller.EditorControllers;

public class EditorGridController
{
	private readonly IGridPointsModelDebug _gridPointsModel; //Field offset: 0x10
	private readonly IWeightCalculatorModelDebug _weightCalculatorModel; //Field offset: 0x18
	private readonly EditorGridView _editorGridView; //Field offset: 0x20

	public EditorGridController(EditorGridView editorGridView, IGridPointsModelDebug gridPointsModel, IWeightCalculatorModelDebug weightCalculatorModel) { }

	protected virtual void Finalize() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	private void UpdateGrid() { }

}

