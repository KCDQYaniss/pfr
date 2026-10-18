//Type is in global namespace

public class Deferred`1 : Compute
{
	private bool _isDirty; //Field offset: 0x0
	private T _value; //Field offset: 0x0

	public bool IsDirty
	{
		 get { } //Length: 5
	}

	public virtual T Value
	{
		 get { } //Length: 63
	}

	public Deferred`1(Func updateFunc) { }

	public bool get_IsDirty() { }

	public virtual T get_Value() { }

	public static T op_Implicit(Deferred deferred) { }

	public virtual void SetDirty() { }

}

