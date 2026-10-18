//Type is in global namespace

public class BotSettingsComponentsMerger
{

	public BotSettingsComponentsMerger() { }

	public static string AddTrailingCommas(string jsonString) { }

	public static string Clear(WildSpawnType role, BotDifficulty dif) { }

	public static string DoClear(string target, string origins, string key) { }

	public static string DoMerge(string from, string to, string key) { }

	private static int FindMatchingBracket(string text, int openBracketPosition, char openBracket, char closeBracket) { }

	public static bool FindNameInJson(string jsonString, string name, int startPosition, out int foundPosition) { }

	private static string FoundValue(string data, string fieldName, int startSearchIndex, out int indexofRemain) { }

	private static string GetSub(string from, string to, string data, int offset = 0) { }

	private static string GetSub(string from, string to, string data, out int open, out int close) { }

	private static string GetSub(int startIndex, string from, string to, string data, out int open, out int close) { }

	public static string RemoveEmptyLines(string input, bool removeComments = true, bool removeEmptyLines = true) { }

}

