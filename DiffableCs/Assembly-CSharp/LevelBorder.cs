//Type is in global namespace

public sealed class LevelBorder : MonoBehaviour
{
	[Space]
	public Vector3[] Points; //Field offset: 0x20

	public LevelBorder() { }

	public ConcaveBorder CreateConcaveBorder() { }

	public int PointIndex(Vector3 position, float precision = 0) { }

}

