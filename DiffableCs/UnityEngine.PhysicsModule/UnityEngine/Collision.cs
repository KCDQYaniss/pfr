namespace UnityEngine;

public class Collision
{
	private ContactPairHeader m_Header; //Field offset: 0x10
	private ContactPair m_Pair; //Field offset: 0x38
	private bool m_Flipped; //Field offset: 0x60
	private ContactPoint[] m_LegacyContacts; //Field offset: 0x68

	public Component body
	{
		 get { } //Length: 38
	}

	public Collider collider
	{
		 get { } //Length: 38
	}

	public ContactPoint[] contacts
	{
		 get { } //Length: 176
	}

	internal bool Flipped
	{
		internal set { } //Length: 4
	}

	public GameObject gameObject
	{
		 get { } //Length: 415
	}

	public Vector3 impulse
	{
		 get { } //Length: 19
	}

	public Vector3 relativeVelocity
	{
		 get { } //Length: 85
	}

	public Collision() { }

	internal Collision(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	public Component get_body() { }

	public Collider get_collider() { }

	public ContactPoint[] get_contacts() { }

	public GameObject get_gameObject() { }

	public Vector3 get_impulse() { }

	public Vector3 get_relativeVelocity() { }

	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }

	internal void set_Flipped(bool value) { }

}

