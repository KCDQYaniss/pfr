namespace EFT;

internal static class LoginStore
{
	private const string PrefsKey = "l.o.g.i.n"; //Field offset: 0x0

	internal static string GetPrefsKey() { }

	internal static Login LoadLogin() { }

	internal static void ResetLogin() { }

	internal static void SaveLogin(Login login) { }

	internal static void SaveLogin(string codedJson) { }

	internal static string ToBase64(Login login) { }

}

