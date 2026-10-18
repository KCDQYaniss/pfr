namespace FastAnimatorSystem;

public abstract class AbstractMotion
{
	public readonly float Duration; //Field offset: 0x10
	public readonly string Name; //Field offset: 0x18

	public abstract bool IsLooped
	{
		 get { } //Length: 0
	}

	protected AbstractMotion(float duration, string name) { }

	public abstract bool get_IsLooped() { }

	public virtual string ToString() { }

}

