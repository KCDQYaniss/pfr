//Type is in global namespace

public class RenderQueue : MonoBehaviour
{
	internal enum Queues
	{
		Cancel = -1,
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		Transparent = 3000,
		Overlay = 4000,
	}

	public int Queue; //Field offset: 0x20
	public Queues SetQueue; //Field offset: 0x24

	public RenderQueue() { }

	private void OnValidate() { }

	private void Start() { }

	private void UpdateQueue() { }

}

