namespace Diz.Binding;

public interface IBindableEvent
{

	public Action Bind(Action handler) { }

	public Action Subscribe(Action handler) { }

}

