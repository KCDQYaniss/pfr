//Type is in global namespace

public class StaticLoot : MonoBehaviour, IStaticLoot
{
	[SerializeField]
	private string _id; //Field offset: 0x20

	public override string Id
	{
		 get { } //Length: 5
	}

	public StaticLoot() { }

	public override string get_Id() { }

}

