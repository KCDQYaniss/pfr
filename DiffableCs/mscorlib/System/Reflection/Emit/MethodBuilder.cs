namespace System.Reflection.Emit;

public sealed class MethodBuilder : MethodInfo
{

	public virtual MethodAttributes Attributes
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

	public virtual string Name
	{
		 get { } //Length: 62
	}

	public virtual Type ReflectedType
	{
		 get { } //Length: 62
	}

	public virtual ICustomAttributeProvider ReturnTypeCustomAttributes
	{
		 get { } //Length: 62
	}

	public ParameterBuilder DefineParameter(int position, ParameterAttributes attributes, string strParamName) { }

	public virtual MethodAttributes get_Attributes() { }

	public virtual Type get_DeclaringType() { }

	public virtual RuntimeMethodHandle get_MethodHandle() { }

	public virtual string get_Name() { }

	public virtual Type get_ReflectedType() { }

	public virtual ICustomAttributeProvider get_ReturnTypeCustomAttributes() { }

	public virtual MethodInfo GetBaseDefinition() { }

	public virtual object[] GetCustomAttributes(bool inherit) { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public ILGenerator GetILGenerator() { }

	public virtual MethodImplAttributes GetMethodImplementationFlags() { }

	public virtual ParameterInfo[] GetParameters() { }

	public virtual object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	public void SetReturnType(Type returnType) { }

}

