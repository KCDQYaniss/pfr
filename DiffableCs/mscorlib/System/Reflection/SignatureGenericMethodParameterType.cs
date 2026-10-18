namespace System.Reflection;

internal sealed class SignatureGenericMethodParameterType : SignatureGenericParameterType
{

	public virtual bool IsGenericMethodParameter
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericTypeParameter
	{
		 get { } //Length: 3
	}

	public virtual string Name
	{
		 get { } //Length: 222
	}

	internal SignatureGenericMethodParameterType(int position) { }

	public virtual bool get_IsGenericMethodParameter() { }

	public virtual bool get_IsGenericTypeParameter() { }

	public virtual string get_Name() { }

}

