namespace WebSocketSharp.Net;

public enum AuthenticationSchemes
{
	None = 0,
	Digest = 1,
	Basic = 8,
	Bearer = 64,
	Anonymous = 32768,
}

