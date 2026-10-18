namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal abstract class ReflectionDelegateFactory
{

	protected ReflectionDelegateFactory() { }

	public abstract Func CreateDefaultConstructor(Type type) { }

	public Func CreateGet(MemberInfo memberInfo) { }

	public abstract Func CreateGet(PropertyInfo propertyInfo) { }

	public abstract Func CreateGet(FieldInfo fieldInfo) { }

	public abstract MethodCall CreateMethodCall(MethodBase method) { }

	public abstract ObjectConstructor CreateParameterizedConstructor(MethodBase method) { }

	public Action CreateSet(MemberInfo memberInfo) { }

	public abstract Action CreateSet(FieldInfo fieldInfo) { }

	public abstract Action CreateSet(PropertyInfo propertyInfo) { }

}

