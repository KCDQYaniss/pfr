//Type is in global namespace

public class ClosestPointSearcher : MonoBehaviour
{
	[SerializeField]
	private AICoversData covers; //Field offset: 0x20
	[SerializeField]
	private float updateInterval; //Field offset: 0x28
	[SerializeField]
	private Color arcColor; //Field offset: 0x2C
	[SerializeField]
	private float arcHeight; //Field offset: 0x3C
	[SerializeField]
	private float lastDistance; //Field offset: 0x40
	private float _nextUpdateTime; //Field offset: 0x44
	public Vector3 p1; //Field offset: 0x48
	public Vector3 p2; //Field offset: 0x54

	public ClosestPointSearcher() { }

	private void OnDrawGizmosSelected() { }

}

