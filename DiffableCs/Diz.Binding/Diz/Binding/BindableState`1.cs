namespace Diz.Binding;

public sealed class BindableState`1 : BaseBindable
{

	public virtual T Value
	{
		 set { } //Length: 38
	}

	public BindableState`1() { }

	public BindableState`1(T initialValue, IEqualityComparer equalityComparer = null) { }

	public virtual void set_Value(T value) { }

}

