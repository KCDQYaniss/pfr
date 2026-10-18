//Type is in global namespace

public class NavGraphWayCalc
{
	private const float COEF = 1; //Field offset: 0x0
	private readonly NavGraphEditorPoint _from; //Field offset: 0x10
	private readonly NavGraphEditorPoint _to; //Field offset: 0x18
	private readonly HashSet _sortedsIds; //Field offset: 0x20
	private readonly SortedSet _sorted; //Field offset: 0x28
	private int _stepCount; //Field offset: 0x30
	private NavGraphContainer _container; //Field offset: 0x38
	private List _way; //Field offset: 0x40
	private bool _haveWay; //Field offset: 0x48

	public NavGraphWayCalc(NavGraphEditorPoint from, NavGraphEditorPoint to, NavGraphContainer container, bool calcNow) { }

	public bool Calc(out List resWay) { }

	public float CalcDist() { }

	private bool CheckPoint(FloatNavGraphPoint from) { }

	public int CountCorners() { }

	public void OnDrawGizmosSelected() { }

	private void OnFinish(bool arg1, FloatNavGraphPoint lastPoint) { }

	private void Step(FloatNavGraphPoint from) { }

}

