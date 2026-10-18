namespace Diz.Binding;

public interface IBindable`1
{

	public T Value
	{
		 get { } //Length: 0
	}

	public Action Bind(Action handler) { }

	public Action BindWithoutValue(ICheckChanges handler) { }

	public T get_Value() { }

	public Action Subscribe(Action handler) { }

}

