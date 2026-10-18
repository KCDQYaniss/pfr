//Type is in global namespace

public abstract class MonoBehaviourSingleton`1 : MonoBehaviour
{

	public static T Instance
	{
		 get { } //Length: 111
	}

	public static bool Instantiated
	{
		 get { } //Length: 104
	}

	protected MonoBehaviourSingleton`1() { }

	public override void Awake() { }

	public static bool Exist(out T component) { }

	public static T get_Instance() { }

	public static bool get_Instantiated() { }

	public override void OnDestroy() { }

}

