namespace Newtonsoft.Json.Linq;

[Nullable(0)]
[NullableContext(1)]
public class JPropertyDescriptor : PropertyDescriptor
{

	public virtual Type ComponentType
	{
		 get { } //Length: 175
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	protected virtual int NameHashCode
	{
		 get { } //Length: 4
	}

	public virtual Type PropertyType
	{
		 get { } //Length: 175
	}

	public JPropertyDescriptor(string name) { }

	public virtual bool CanResetValue(object component) { }

	private static JObject CastInstance(object instance) { }

	public virtual Type get_ComponentType() { }

	public virtual bool get_IsReadOnly() { }

	protected virtual int get_NameHashCode() { }

	public virtual Type get_PropertyType() { }

	public virtual object GetValue(object component) { }

	public virtual void ResetValue(object component) { }

	public virtual void SetValue(object component, object value) { }

	public virtual bool ShouldSerializeValue(object component) { }

}

