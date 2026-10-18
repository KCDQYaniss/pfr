namespace Sirenix.Serialization;

public static class SerializationUtility
{

	public static object CreateCopy(object obj) { }

	public static IDataReader CreateReader(Stream stream, DeserializationContext context, DataFormat format) { }

	public static IDataWriter CreateWriter(Stream stream, SerializationContext context, DataFormat format) { }

	public static T DeserializeValue(byte[] bytes, DataFormat format, DeserializationContext context = null) { }

	public static T DeserializeValue(Stream stream, DataFormat format, List referencedUnityObjects, DeserializationContext context = null) { }

	public static T DeserializeValue(Stream stream, DataFormat format, DeserializationContext context = null) { }

	public static T DeserializeValue(IDataReader reader, List referencedUnityObjects) { }

	public static T DeserializeValue(IDataReader reader) { }

	public static T DeserializeValue(byte[] bytes, DataFormat format, List referencedUnityObjects, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(byte[] bytes, DataFormat format, List referencedUnityObjects) { }

	public static object DeserializeValueWeak(byte[] bytes, DataFormat format, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(Stream stream, DataFormat format, List referencedUnityObjects, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(Stream stream, DataFormat format, DeserializationContext context = null) { }

	public static object DeserializeValueWeak(IDataReader reader, List referencedUnityObjects) { }

	public static object DeserializeValueWeak(IDataReader reader) { }

	private static IDataReader GetCachedReader(out IDisposable cache, DataFormat format, Stream stream, DeserializationContext context) { }

	private static IDataWriter GetCachedWriter(out IDisposable cache, DataFormat format, Stream stream, SerializationContext context) { }

	public static byte[] SerializeValue(T value, DataFormat format, out List unityObjects, SerializationContext context = null) { }

	public static void SerializeValue(T value, Stream stream, DataFormat format, out List unityObjects, SerializationContext context = null) { }

	public static void SerializeValue(T value, Stream stream, DataFormat format, SerializationContext context = null) { }

	public static void SerializeValue(T value, IDataWriter writer, out List unityObjects) { }

	public static void SerializeValue(T value, IDataWriter writer) { }

	public static byte[] SerializeValue(T value, DataFormat format, SerializationContext context = null) { }

	public static byte[] SerializeValueWeak(object value, DataFormat format, SerializationContext context = null) { }

	public static void SerializeValueWeak(object value, Stream stream, DataFormat format, out List unityObjects, SerializationContext context = null) { }

	public static void SerializeValueWeak(object value, Stream stream, DataFormat format, SerializationContext context = null) { }

	public static void SerializeValueWeak(object value, IDataWriter writer, out List unityObjects) { }

	public static void SerializeValueWeak(object value, IDataWriter writer) { }

	public static byte[] SerializeValueWeak(object value, DataFormat format, out List unityObjects) { }

}

