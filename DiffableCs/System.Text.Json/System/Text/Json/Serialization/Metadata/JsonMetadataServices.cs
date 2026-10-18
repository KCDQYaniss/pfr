namespace System.Text.Json.Serialization.Metadata;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Nullable(0)]
[NullableContext(1)]
public static class JsonMetadataServices
{
	private static JsonConverter s_booleanConverter; //Field offset: 0x0
	private static JsonConverter s_byteArrayConverter; //Field offset: 0x8
	private static JsonConverter s_byteConverter; //Field offset: 0x10
	private static JsonConverter s_charConverter; //Field offset: 0x18
	private static JsonConverter s_dateTimeConverter; //Field offset: 0x20
	private static JsonConverter s_dateTimeOffsetConverter; //Field offset: 0x28
	private static JsonConverter s_decimalConverter; //Field offset: 0x30
	private static JsonConverter s_doubleConverter; //Field offset: 0x38
	private static JsonConverter s_guidConverter; //Field offset: 0x40
	private static JsonConverter s_int16Converter; //Field offset: 0x48
	private static JsonConverter s_int32Converter; //Field offset: 0x50
	private static JsonConverter s_int64Converter; //Field offset: 0x58
	private static JsonConverter s_jsonElementConverter; //Field offset: 0x60
	private static JsonConverter s_jsonDocumentConverter; //Field offset: 0x68
	private static JsonConverter s_memoryByteConverter; //Field offset: 0x70
	private static JsonConverter s_readOnlyMemoryByteConverter; //Field offset: 0x78
	private static JsonConverter s_objectConverter; //Field offset: 0x80
	private static JsonConverter s_singleConverter; //Field offset: 0x88
	private static JsonConverter s_sbyteConverter; //Field offset: 0x90
	private static JsonConverter s_stringConverter; //Field offset: 0x98
	private static JsonConverter s_timeSpanConverter; //Field offset: 0xA0
	private static JsonConverter s_uint16Converter; //Field offset: 0xA8
	private static JsonConverter s_uint32Converter; //Field offset: 0xB0
	private static JsonConverter s_uint64Converter; //Field offset: 0xB8
	private static JsonConverter s_uriConverter; //Field offset: 0xC0
	private static JsonConverter s_versionConverter; //Field offset: 0xC8

	public static JsonConverter BooleanConverter
	{
		 get { } //Length: 270
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public static JsonConverter ByteArrayConverter
	{
		 get { } //Length: 270
	}

	public static JsonConverter ByteConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter CharConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter DateTimeConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter DateTimeOffsetConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter DecimalConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter DoubleConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter GuidConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter Int16Converter
	{
		 get { } //Length: 286
	}

	public static JsonConverter Int32Converter
	{
		 get { } //Length: 286
	}

	public static JsonConverter Int64Converter
	{
		 get { } //Length: 286
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public static JsonConverter JsonDocumentConverter
	{
		 get { } //Length: 270
	}

	public static JsonConverter JsonElementConverter
	{
		 get { } //Length: 270
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 0})]
	public static JsonConverter MemoryByteConverter
	{
		 get { } //Length: 270
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public static JsonConverter ObjectConverter
	{
		 get { } //Length: 286
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 0})]
	public static JsonConverter ReadOnlyMemoryByteConverter
	{
		 get { } //Length: 270
	}

	[CLSCompliant(False)]
	public static JsonConverter SByteConverter
	{
		 get { } //Length: 302
	}

	public static JsonConverter SingleConverter
	{
		 get { } //Length: 302
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public static JsonConverter StringConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter TimeSpanConverter
	{
		 get { } //Length: 286
	}

	[CLSCompliant(False)]
	public static JsonConverter UInt16Converter
	{
		 get { } //Length: 302
	}

	[CLSCompliant(False)]
	public static JsonConverter UInt32Converter
	{
		 get { } //Length: 302
	}

	[CLSCompliant(False)]
	public static JsonConverter UInt64Converter
	{
		 get { } //Length: 302
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public static JsonConverter UriConverter
	{
		 get { } //Length: 286
	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 2})]
	public static JsonConverter VersionConverter
	{
		 get { } //Length: 286
	}

	public static JsonConverter get_BooleanConverter() { }

	public static JsonConverter get_ByteArrayConverter() { }

	public static JsonConverter get_ByteConverter() { }

	public static JsonConverter get_CharConverter() { }

	public static JsonConverter get_DateTimeConverter() { }

	public static JsonConverter get_DateTimeOffsetConverter() { }

	public static JsonConverter get_DecimalConverter() { }

	public static JsonConverter get_DoubleConverter() { }

	public static JsonConverter get_GuidConverter() { }

	public static JsonConverter get_Int16Converter() { }

	public static JsonConverter get_Int32Converter() { }

	public static JsonConverter get_Int64Converter() { }

	public static JsonConverter get_JsonDocumentConverter() { }

	public static JsonConverter get_JsonElementConverter() { }

	public static JsonConverter get_MemoryByteConverter() { }

	public static JsonConverter get_ObjectConverter() { }

	public static JsonConverter get_ReadOnlyMemoryByteConverter() { }

	public static JsonConverter get_SByteConverter() { }

	public static JsonConverter get_SingleConverter() { }

	public static JsonConverter get_StringConverter() { }

	public static JsonConverter get_TimeSpanConverter() { }

	public static JsonConverter get_UInt16Converter() { }

	public static JsonConverter get_UInt32Converter() { }

	public static JsonConverter get_UInt64Converter() { }

	public static JsonConverter get_UriConverter() { }

	public static JsonConverter get_VersionConverter() { }

	internal static void PopulateProperties(JsonTypeInfo typeInfo, JsonPropertyInfoList propertyList, Func propInitFunc) { }

}

