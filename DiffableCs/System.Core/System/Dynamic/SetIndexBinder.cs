namespace System.Dynamic;

public abstract class SetIndexBinder : DynamicMetaObjectBinder
{

	public virtual Type ReturnType
	{
		 get { } //Length: 175
	}

	public virtual DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }

	public virtual Type get_ReturnType() { }

}

