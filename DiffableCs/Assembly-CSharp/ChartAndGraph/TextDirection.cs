namespace ChartAndGraph;

[ExecuteInEditMode]
public class TextDirection : MonoBehaviour
{
	public Material PointMaterial; //Field offset: 0x20
	public Material LineMaterial; //Field offset: 0x28
	public float Length; //Field offset: 0x30
	public float Gap; //Field offset: 0x34
	public float Thickness; //Field offset: 0x38
	public float PointSize; //Field offset: 0x3C
	public CanvasLines Lines; //Field offset: 0x40
	public CanvasLines Point; //Field offset: 0x48
	public Text Text; //Field offset: 0x50
	private Transform _relativeTo; //Field offset: 0x58
	private Transform _relativeFrom; //Field offset: 0x60
	private TextController _controller; //Field offset: 0x68

	public TextDirection() { }

	public void LateUpdate() { }

	public void SetDirection(float angle) { }

	private void SetDirection(Vector3 dir) { }

	public void SetRelativeTo(Transform from, Transform to) { }

	public void SetTextController(TextController control) { }

}

