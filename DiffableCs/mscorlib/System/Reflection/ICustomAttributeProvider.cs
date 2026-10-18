namespace System.Reflection;

public interface ICustomAttributeProvider
{

	public object[] GetCustomAttributes(bool inherit) { }

	public object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public bool IsDefined(Type attributeType, bool inherit) { }

}

