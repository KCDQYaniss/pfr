namespace Microsoft.CSharp.RuntimeBinder;

internal sealed class CSharpInvokeConstructorBinder : DynamicMetaObjectBinder
{
	private readonly CSharpArgumentInfo[] _argumentInfo; //Field offset: 0x18
	private readonly RuntimeBinder _binder; //Field offset: 0x20

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

}

