//Type is in global namespace

public sealed class JsonResponse
{
	public int err; //Field offset: 0x10
	public string errmsg; //Field offset: 0x18
	public UnparsedData data; //Field offset: 0x20
	public uint crc; //Field offset: 0x28

	public JsonResponse() { }

}

