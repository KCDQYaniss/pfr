namespace UnityEngine;

public struct JointDrive
{
	private float m_PositionSpring; //Field offset: 0x0
	private float m_PositionDamper; //Field offset: 0x4
	private float m_MaximumForce; //Field offset: 0x8
	private int m_UseAcceleration; //Field offset: 0xC

	public float maximumForce
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float positionDamper
	{
		 get { } //Length: 452
		 set { } //Length: 6
	}

	public float positionSpring
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public float get_maximumForce() { }

	public float get_positionDamper() { }

	public float get_positionSpring() { }

	public void set_maximumForce(float value) { }

	public void set_positionDamper(float value) { }

	public void set_positionSpring(float value) { }

}

