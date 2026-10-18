namespace System.Xml.Serialization;

internal class XmlCustomFormatter
{
	private static string[] allTimeFormats; //Field offset: 0x0

	private static XmlCustomFormatter() { }

	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	internal static string FromXmlName(string name) { }

	internal static string FromXmlNCName(string ncName) { }

	internal static object FromXmlString(TypeData type, string value) { }

	internal static string ToXmlString(TypeData type, object value) { }

}

