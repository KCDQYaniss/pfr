//Type is in global namespace

public class BackendResponse
{
	public int Code; //Field offset: 0x10
	public string Error; //Field offset: 0x18
	public string Result; //Field offset: 0x20
	public Dictionary Headers; //Field offset: 0x28
	public string Url; //Field offset: 0x30
	public string Method; //Field offset: 0x38

	public BackendResponse() { }

}

