namespace UnityEngine;

public class WWWForm
{
	private static byte[] dDash; //Field offset: 0x0
	private static byte[] crlf; //Field offset: 0x8
	private static byte[] contentTypeHeader; //Field offset: 0x10
	private static byte[] dispositionHeader; //Field offset: 0x18
	private static byte[] endQuote; //Field offset: 0x20
	private static byte[] fileNameField; //Field offset: 0x28
	private static byte[] ampersand; //Field offset: 0x30
	private static byte[] equal; //Field offset: 0x38

	internal static Encoding DefaultEncoding
	{
		internal get { } //Length: 9
	}

	private static WWWForm() { }

	internal static Encoding get_DefaultEncoding() { }

}

