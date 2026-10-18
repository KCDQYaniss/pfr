namespace System.Text.Json.Serialization.Metadata;

internal class JsonTypeInfoResolverChain : ConfigurationList, IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
{

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public JsonTypeInfoResolverChain() { }

	internal void AddFlattened(IJsonTypeInfoResolver resolver) { }

	public virtual bool get_IsReadOnly() { }

	public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options) { }

	protected virtual void OnCollectionModifying() { }

	private override bool System.Text.Json.Serialization.Metadata.IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(JsonSerializerOptions options) { }

	public virtual string ToString() { }

}

