namespace Systems.Effects;

public class LazyComponent`1
{
	private readonly MonoBehaviour _source; //Field offset: 0x0
	private T _component; //Field offset: 0x0
	private bool _initialized; //Field offset: 0x0

	public T Component
	{
		 get { } //Length: 81
	}

	public LazyComponent`1(MonoBehaviour source) { }

	private void EnsureInitialized() { }

	public bool Equals(LazyComponent other) { }

	public virtual bool Equals(object obj) { }

	public T get_Component() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(LazyComponent lazy, bool hasComponent) { }

	public static T op_Implicit(LazyComponent lazy) { }

	public static bool op_Implicit(LazyComponent lazy) { }

	public static bool op_Inequality(LazyComponent lazy, bool hasComponent) { }

}

