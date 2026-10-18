namespace ChartAndGraph.Axis;

public interface IAxisGenerator
{

	public GameObject GetGameObject() { }

	public void SetAxis(double scrollOffset, AnyChart parent, AxisBase axis, ChartOrientation axisOrientation, bool isSubDivisions) { }

	public Object This() { }

}

