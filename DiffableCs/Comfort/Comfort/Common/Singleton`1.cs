namespace Comfort.Common;

public class Singleton`1
{
	private static T _instance; //Field offset: 0x0

	public static T Instance
	{
		 get { } //Length: 80
		 set { } //Length: 54
	}

	public static bool Instantiated
	{
		 get { } //Length: 72
	}

	public Singleton`1() { }

	public static void Create(T instance) { }

	public static T get_Instance() { }

	public static bool get_Instantiated() { }

	public static void Release(T instance) { }

	public static void set_Instance(T value) { }

	public static bool TryRelease(T instance) { }

}

