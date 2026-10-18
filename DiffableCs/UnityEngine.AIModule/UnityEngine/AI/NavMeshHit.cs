namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
public struct NavMeshHit
{
	private Vector3 m_Position; //Field offset: 0x0
	private Vector3 m_Normal; //Field offset: 0xC
	private float m_Distance; //Field offset: 0x18
	private int m_Mask; //Field offset: 0x1C
	private int m_Hit; //Field offset: 0x20

	public float distance
	{
		 get { } //Length: 8
	}

	public bool hit
	{
		 get { } //Length: 10
	}

	public int mask
	{
		 get { } //Length: 6
	}

	public Vector3 position
	{
		 get { } //Length: 18
	}

	public float get_distance() { }

	public bool get_hit() { }

	public int get_mask() { }

	public Vector3 get_position() { }

}

