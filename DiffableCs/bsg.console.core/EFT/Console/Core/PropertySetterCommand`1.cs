namespace EFT.Console.Core;

public abstract class PropertySetterCommand`1 : SyncCommand
{
	private readonly T _data; //Field offset: 0x0
	private readonly bool _hasData; //Field offset: 0x0

	public virtual object[] ArgumentsValue
	{
		 get { } //Length: 396
	}

	public PropertySetterCommand`1() { }

	public PropertySetterCommand`1(T data) { }

	protected override string DisplayValue(T data) { }

	public virtual void Execute() { }

	protected abstract T Get() { }

	public virtual object[] get_ArgumentsValue() { }

	protected abstract void Set(T v) { }

}

