namespace Sirenix.Serialization;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True)]
public sealed class RegisterDictionaryKeyPathProviderAttribute : Attribute
{
	public readonly Type ProviderType; //Field offset: 0x10

	public RegisterDictionaryKeyPathProviderAttribute(Type providerType) { }

}

