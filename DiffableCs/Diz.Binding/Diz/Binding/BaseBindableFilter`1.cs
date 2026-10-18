namespace Diz.Binding;

public abstract class BaseBindableFilter`1 : BaseBindable
{
	protected Action[] Subscriptions; //Field offset: 0x0

	protected BaseBindableFilter`1() { }

	public virtual Action Bind(Action handler) { }

	public virtual Action BindWithoutValue(ICheckChanges handler) { }

	protected abstract void Connect() { }

	public void Disconnect() { }

	protected void SetSubscriptions(Action[] subscriptions) { }

	protected virtual void Unbind(Action handler) { }

}

