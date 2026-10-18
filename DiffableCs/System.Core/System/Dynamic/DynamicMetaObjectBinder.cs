namespace System.Dynamic;

public abstract class DynamicMetaObjectBinder : CallSiteBinder
{

	internal override bool IsStandardBinder
	{
		internal get { } //Length: 3
	}

	public override Type ReturnType
	{
		 get { } //Length: 175
	}

	protected DynamicMetaObjectBinder() { }

	public virtual Expression Bind(object[] args, ReadOnlyCollection parameters, LabelTarget returnLabel) { }

	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection parameters) { }

	public DynamicMetaObject Defer(DynamicMetaObject target, DynamicMetaObject[] args) { }

	internal override bool get_IsStandardBinder() { }

	public override Type get_ReturnType() { }

	public Expression GetUpdateExpression(Type type) { }

	private DynamicMetaObject MakeDeferred(BindingRestrictions rs, DynamicMetaObject[] args) { }

}

