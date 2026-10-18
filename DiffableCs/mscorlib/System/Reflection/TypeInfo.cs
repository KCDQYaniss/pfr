namespace System.Reflection;

public abstract class TypeInfo : Type, IReflectableType
{
	private const BindingFlags DeclaredOnlyLookup = 62; //Field offset: 0x0

	public override IEnumerable ImplementedInterfaces
	{
		 get { } //Length: 20
	}

	protected TypeInfo() { }

	public override IEnumerable get_ImplementedInterfaces() { }

	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

