namespace System.Reflection.Emit;

public sealed class DynamicMethod : MethodInfo
{

	public virtual MethodAttributes Attributes
	{
		 get { } //Length: 62
	}

	public virtual CallingConventions CallingConvention
	{
		 get { } //Length: 62
	}

	public virtual Type DeclaringType
	{
		 get { } //Length: 62
	}

	public virtual RuntimeMethodHandle MethodHandle
	{
		 get { } //Length: 62
	}

	public virtual Module Module
	{
		 get { } //Length: 62
	}

	public virtual string Name
	{
		 get { } //Length: 62
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 62
	}

	public virtual ParameterInfo ReturnParameter
	{
		 get { } //Length: 62
	}

	public virtual Type ReturnType
	{
		 get { } //Length: 62
	}

	public virtual ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		 get { } //Length: 62
	}

	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility) { }

	public DynamicMethod(string name, MethodAttributes attributes, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) { }

	public virtual Delegate CreateDelegate(Type delegateType) { }

	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	public virtual MethodAttributes get_Attributes() { }

	public virtual CallingConventions get_CallingConvention() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual Module get_Module() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual ParameterInfo get_ReturnParameter() { }

	public virtual Type get_ReturnType() { }

	public virtual ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	public virtual MethodInfo GetBaseDefinition() { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public virtual object[] GetCustomAttributes(bool inherit) { }

	public ILGenerator GetILGenerator() { }

	public ILGenerator GetILGenerator(int streamSize) { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public virtual ParameterInfo[] GetParameters() { }

	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public virtual string ToString() { }

}

