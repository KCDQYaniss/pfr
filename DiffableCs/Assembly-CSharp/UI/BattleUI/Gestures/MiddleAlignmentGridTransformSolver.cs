namespace UI.BattleUI.Gestures;

public class MiddleAlignmentGridTransformSolver : BaseTransformSolver
{
	[SerializeField]
	private Transform _rowTemplate; //Field offset: 0x20
	[SerializeField]
	private int _maxItemsInRow; //Field offset: 0x28
	private readonly List _rows; //Field offset: 0x30
	private int _itemsInLastRow; //Field offset: 0x38

	public MiddleAlignmentGridTransformSolver() { }

	public virtual void CleanUp() { }

	private Transform GetOrCreateGestureItemsRow() { }

	public virtual void SetChild(Transform child) { }

}

