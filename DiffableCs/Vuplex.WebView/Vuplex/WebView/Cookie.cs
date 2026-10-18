namespace Vuplex.WebView;

public class Cookie
{
	public string Name; //Field offset: 0x10
	public string Value; //Field offset: 0x18
	public string Domain; //Field offset: 0x20
	public string Path; //Field offset: 0x28
	public int ExpirationDate; //Field offset: 0x30
	public bool HttpOnly; //Field offset: 0x34
	public bool Secure; //Field offset: 0x35

	public bool IsValid
	{
		 get { } //Length: 713
	}

	public Cookie() { }

	public static Cookie[] ArrayFromJson(string serializedCookies) { }

	public static Cookie FromJson(string serializedCookie) { }

	public bool get_IsValid() { }

	public string ToJson() { }

	public virtual string ToString() { }

}

