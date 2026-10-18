namespace UnityEngine;

public struct SoftJointLimit
{
	private float m_Limit; //Field offset: 0x0
	private float m_Bounciness; //Field offset: 0x4
	private float m_ContactDistance; //Field offset: 0x8

	public float bounciness
	{
		 get { } //Length: 452
		 set { } //Length: 6
	}

	public float contactDistance
	{
		 get { } //Length: 8
		 set { } //Length: 6
	}

	public float limit
	{
		 get { } //Length: 7
		 set { } //Length: 5
	}

	public float get_bounciness() { }

	public float get_contactDistance() { }

	public float get_limit() { }

	public void set_bounciness(float value) { }

	public void set_contactDistance(float value) { }

	public void set_limit(float value) { }

}

