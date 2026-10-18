//Type is in global namespace

public class Wind : MonoBehaviour
{
	[MinValue(0)]
	public float m_Speed; //Field offset: 0x20

	public Wind() { }

	private void OnDrawGizmosSelected() { }

}

