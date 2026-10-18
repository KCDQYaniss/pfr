namespace Bsg.GameSettings;

public sealed class Accessor`1 : IAccessor, IBindable
{
	private readonly GameSetting _gameSetting; //Field offset: 0x0
	private readonly Func _setter; //Field offset: 0x0

	private override T Diz.Binding.IBindable<T>.Value
	{
		private get { } //Length: 166
	}

	public Accessor`1(GameSetting gameSetting, Func setter = null) { }

	private override Task Bsg.GameSettings.IAccessor<T>.Set(T t) { }

	private override Action Diz.Binding.IBindable<T>.Bind(Action handler) { }

	private override Action Diz.Binding.IBindable<T>.BindWithoutValue(ICheckChanges handler) { }

	private override T Diz.Binding.IBindable<T>.get_Value() { }

	private override Action Diz.Binding.IBindable<T>.Subscribe(Action handler) { }

	private Task Set(T t) { }

}

