//Type is in global namespace

public sealed class WsResponseJson
{
	internal class WsSenderResponseError
	{
		public string Code; //Field offset: 0x10
		public string Message; //Field offset: 0x18

		public WsSenderResponseError() { }

		public virtual string ToString() { }

	}

	public UnparsedData Result; //Field offset: 0x10
	public WsSenderResponseError Error; //Field offset: 0x18
	public string ID; //Field offset: 0x20
	public string Method; //Field offset: 0x28
	public string Status; //Field offset: 0x30

	public WsResponseJson() { }

	public virtual string ToString() { }

}

