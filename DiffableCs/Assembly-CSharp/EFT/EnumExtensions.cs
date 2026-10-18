namespace EFT;

[Extension]
public static class EnumExtensions
{

	[Extension]
	public static void AddFlag(ref T value, T flag) { }

	[Extension]
	public static bool EqualsNoBox(T x, T y) { }

	[Extension]
	public static byte GetByte(T value) { }

	[Extension]
	public static int GetIndex(T value) { }

	[Extension]
	public static int GetInt(T value) { }

	[Extension]
	public static long GetLong(T value) { }

	[Extension]
	public static short GetShort(T value) { }

	[Extension]
	public static bool HasFlagNoBox(T value, T flag) { }

	[Extension]
	public static bool Is(T enumWithFlags, T value) { }

	[Extension]
	public static bool IsCorrectValue(T value) { }

	[Extension]
	public static string LocalizationKey(T value) { }

	[Extension]
	public static void RemoveFlag(ref T value, T flag) { }

	[Extension]
	public static string ToJsonName(T value) { }

	[Extension]
	public static string ToStringNoBox(T value) { }

}

