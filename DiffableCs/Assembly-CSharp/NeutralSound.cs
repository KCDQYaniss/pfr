//Type is in global namespace

public class NeutralSound
{
	public float Time; //Field offset: 0x10
	public IPlayer Player; //Field offset: 0x18
	public Vector3 Position; //Field offset: 0x20

	public NeutralSound(IPlayer player, Vector3 position) { }

	public virtual string ToString() { }

}

