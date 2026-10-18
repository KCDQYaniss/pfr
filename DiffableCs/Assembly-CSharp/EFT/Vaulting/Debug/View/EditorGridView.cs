namespace EFT.Vaulting.Debug.View;

public class EditorGridView : MonoBehaviour
{
	[SerializeField]
	private bool _drawRootPoint; //Field offset: 0x20
	[SerializeField]
	private bool _drawHitPoints; //Field offset: 0x21
	private GridPointsDataModel _dataModel; //Field offset: 0x28
	[CompilerGenerated]
	private Action OnUpdateTransform; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnUpdateDrawGrid; //Field offset: 0x88

	public event Action OnUpdateDrawGrid
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnUpdateTransform
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public EditorGridView() { }

	[CompilerGenerated]
	public void add_OnUpdateDrawGrid(Action value) { }

	[CompilerGenerated]
	public void add_OnUpdateTransform(Action value) { }

	private void DrawHitPoints() { }

	private void DrawPoint(Vector3 position, Color color) { }

	private void DrawRootPoint() { }

	private void OnDrawGizmos() { }

	[CompilerGenerated]
	public void remove_OnUpdateDrawGrid(Action value) { }

	[CompilerGenerated]
	public void remove_OnUpdateTransform(Action value) { }

	public void UpdateDataModel(GridPointsDataModel dataModel) { }

}

