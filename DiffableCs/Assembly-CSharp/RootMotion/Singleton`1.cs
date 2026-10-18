namespace RootMotion;

public abstract class Singleton`1 : MonoBehaviour
{
	private static T sInstance; //Field offset: 0x0

	public static T instance
	{
		 get { } //Length: 80
	}

	protected Singleton`1() { }

	protected override void Awake() { }

	public static T get_instance() { }

}

