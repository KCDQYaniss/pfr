namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
public interface IAttributeProvider
{

	public IList GetAttributes(bool inherit) { }

	public IList GetAttributes(Type attributeType, bool inherit) { }

}

