namespace ChartAndGraph;

public class InfoBox : MonoBehaviour
{
	public GraphChartBase[] GraphChart; //Field offset: 0x20
	public Text infoText; //Field offset: 0x28

	public InfoBox() { }

	private void GraphClicked(GraphEventArgs args) { }

	private void GraphHoverd(GraphEventArgs args) { }

	public void HookChartEvents() { }

	private void NonHovered() { }

	private void Start() { }

}

