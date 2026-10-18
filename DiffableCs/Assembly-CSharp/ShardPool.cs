//Type is in global namespace

public class ShardPool : MonoBehaviour
{
	private static ShardPool pool; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private Shard[] shards; //Field offset: 0x20
	[SerializeField]
	private int maxPoolSize; //Field offset: 0x28
	private int nextFreeShard; //Field offset: 0x2C

	private static bool CanGetNextShard
	{
		private get { } //Length: 90
	}

	public bool IsPopulated
	{
		 get { } //Length: 9
	}

	public static Shard NextShard
	{
		 get { } //Length: 178
	}

	public static int ShardsUsed
	{
		 get { } //Length: 79
	}

	public ShardPool() { }

	private void Awake() { }

	public static void CheckPool() { }

	private static void FindPoolInScene() { }

	private static bool get_CanGetNextShard() { }

	public bool get_IsPopulated() { }

	public static Shard get_NextShard() { }

	public static int get_ShardsUsed() { }

	public void PopulatePool() { }

}

