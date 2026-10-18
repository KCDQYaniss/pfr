//Type is in global namespace

public class GraphAnimation : MonoBehaviour
{
	private class InnerAnimation
	{
		public float maxX; //Field offset: 0x10
		public float minX; //Field offset: 0x14
		public float maxY; //Field offset: 0x18
		public float minY; //Field offset: 0x1C
		public float totalTime; //Field offset: 0x20
		public float next; //Field offset: 0x24
		public string category; //Field offset: 0x28
		public List points; //Field offset: 0x30
		public int index; //Field offset: 0x38

		public InnerAnimation() { }

		public void Update(GraphChartBase graphChart) { }

	}

	private GraphChartBase graphChart; //Field offset: 0x20
	public float AnimationTime; //Field offset: 0x28
	public bool ModifyRange; //Field offset: 0x2C
	private Dictionary mAnimations; //Field offset: 0x30

	public GraphAnimation() { }

	public void Animate(string category, List points, float totalTime) { }

	private bool IsValidFloat(float val) { }

	private void Start() { }

	private void Update() { }

}

