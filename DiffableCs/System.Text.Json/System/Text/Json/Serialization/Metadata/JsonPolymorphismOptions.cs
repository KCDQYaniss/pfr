namespace System.Text.Json.Serialization.Metadata;

[Nullable(0)]
[NullableContext(1)]
public class JsonPolymorphismOptions
{
	private sealed class DerivedTypeList : ConfigurationList
	{
		private readonly JsonPolymorphismOptions _parent; //Field offset: 0x18

		public virtual bool IsReadOnly
		{
			 get { } //Length: 41
		}

		public DerivedTypeList(JsonPolymorphismOptions parent) { }

		public virtual bool get_IsReadOnly() { }

		protected virtual void OnCollectionModifying() { }

	}

	private DerivedTypeList _derivedTypes; //Field offset: 0x10
	private bool _ignoreUnrecognizedTypeDiscriminators; //Field offset: 0x18
	private JsonUnknownDerivedTypeHandling _unknownDerivedTypeHandling; //Field offset: 0x1C
	private string _typeDiscriminatorPropertyName; //Field offset: 0x20
	[CompilerGenerated]
	private JsonTypeInfo <DeclaringTypeInfo>k__BackingField; //Field offset: 0x28

	[Nullable(2)]
	internal JsonTypeInfo DeclaringTypeInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public IList DerivedTypes
	{
		 get { } //Length: 481
	}

	public bool IgnoreUnrecognizedTypeDiscriminators
	{
		 get { } //Length: 5
		 set { } //Length: 41
	}

	public string TypeDiscriminatorPropertyName
	{
		 get { } //Length: 66
		 set { } //Length: 109
	}

	public JsonUnknownDerivedTypeHandling UnknownDerivedTypeHandling
	{
		 get { } //Length: 4
		 set { } //Length: 41
	}

	public JsonPolymorphismOptions() { }

	internal static JsonPolymorphismOptions CreateFromAttributeDeclarations(Type baseType) { }

	[CompilerGenerated]
	internal JsonTypeInfo get_DeclaringTypeInfo() { }

	public IList get_DerivedTypes() { }

	public bool get_IgnoreUnrecognizedTypeDiscriminators() { }

	public string get_TypeDiscriminatorPropertyName() { }

	public JsonUnknownDerivedTypeHandling get_UnknownDerivedTypeHandling() { }

	[CompilerGenerated]
	internal void set_DeclaringTypeInfo(JsonTypeInfo value) { }

	public void set_IgnoreUnrecognizedTypeDiscriminators(bool value) { }

	public void set_TypeDiscriminatorPropertyName(string value) { }

	public void set_UnknownDerivedTypeHandling(JsonUnknownDerivedTypeHandling value) { }

	private void VerifyMutable() { }

}

