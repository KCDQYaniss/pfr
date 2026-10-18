namespace Diz.Binding;

public interface IBindableEvent`1
{

	public Action Bind(Action handler, T defaultValue) { }

	public Action Subscribe(Action handler) { }

}

