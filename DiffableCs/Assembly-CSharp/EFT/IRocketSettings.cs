namespace EFT;

public interface IRocketSettings
{

	public float Drag
	{
		 get { } //Length: 0
	}

	public Material ExplosionParticleMaterial
	{
		 get { } //Length: 0
	}

	public ICollection MeshRenderers
	{
		 get { } //Length: 0
	}

	public Rigidbody Rigidbody
	{
		 get { } //Length: 0
	}

	public Collider SelfCollider
	{
		 get { } //Length: 0
	}

	public float StartSpeed
	{
		 get { } //Length: 0
	}

	public float Weight
	{
		 get { } //Length: 0
	}

	public float get_Drag() { }

	public Material get_ExplosionParticleMaterial() { }

	public ICollection get_MeshRenderers() { }

	public Rigidbody get_Rigidbody() { }

	public Collider get_SelfCollider() { }

	public float get_StartSpeed() { }

	public float get_Weight() { }

}

