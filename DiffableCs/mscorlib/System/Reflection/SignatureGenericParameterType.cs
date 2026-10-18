namespace System.Reflection;

internal abstract class SignatureGenericParameterType : SignatureType
{
	private readonly int _position; //Field offset: 0x18

	public virtual bool ContainsGenericParameters
	{
		 get { } //Length: 3
	}

	internal virtual SignatureType ElementType
	{
		internal get { } //Length: 3
	}

	public virtual int GenericParameterPosition
	{
		 get { } //Length: 4
	}

	public virtual Type[] GenericTypeArguments
	{
		 get { } //Length: 53
	}

	public virtual bool IsByRefLike
	{
		 get { } //Length: 3
	}

	public virtual bool IsConstructedGenericType
	{
		 get { } //Length: 3
	}

	public abstract bool IsGenericMethodParameter
	{
		 get { } //Length: 0
	}

	public virtual bool IsGenericParameter
	{
		 get { } //Length: 3
	}

	public virtual bool IsGenericTypeDefinition
	{
		 get { } //Length: 3
	}

	public virtual bool IsSZArray
	{
		 get { } //Length: 3
	}

	public virtual bool IsTypeDefinition
	{
		 get { } //Length: 3
	}

	public virtual bool IsVariableBoundArray
	{
		 get { } //Length: 3
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public virtual string Namespace
	{
		 get { } //Length: 3
	}

	protected SignatureGenericParameterType(int position) { }

	public virtual bool get_ContainsGenericParameters() { }

	internal virtual SignatureType get_ElementType() { }

	public virtual int get_GenericParameterPosition() { }

	public virtual Type[] get_GenericTypeArguments() { }

	public virtual bool get_IsByRefLike() { }

	public virtual bool get_IsConstructedGenericType() { }

	public abstract bool get_IsGenericMethodParameter() { }

	public virtual bool get_IsGenericParameter() { }

	public virtual bool get_IsGenericTypeDefinition() { }

	public virtual bool get_IsSZArray() { }

	public virtual bool get_IsTypeDefinition() { }

	public virtual bool get_IsVariableBoundArray() { }

	public abstract string get_Name() { }

	public virtual string get_Namespace() { }

	public virtual int GetArrayRank() { }

	public virtual Type[] GetGenericArguments() { }

	public virtual Type GetGenericTypeDefinition() { }

	protected virtual bool HasElementTypeImpl() { }

	protected virtual bool IsArrayImpl() { }

	protected virtual bool IsByRefImpl() { }

	protected virtual bool IsPointerImpl() { }

	public virtual string ToString() { }

}

