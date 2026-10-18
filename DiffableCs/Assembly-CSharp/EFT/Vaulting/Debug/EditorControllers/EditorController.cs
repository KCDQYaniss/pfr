namespace EFT.Vaulting.Debug.EditorControllers;

public class EditorController
{
	private readonly EditorView _editorView; //Field offset: 0x10
	private readonly IVaultingModelDebug _model; //Field offset: 0x18
	private EditorGridController _editorGridController; //Field offset: 0x20
	private EditorApproximationController _editorApproximationController; //Field offset: 0x28

	public EditorController(EditorView editorView, IVaultingModelDebug model) { }

	private void InitializeControllers() { }

}

