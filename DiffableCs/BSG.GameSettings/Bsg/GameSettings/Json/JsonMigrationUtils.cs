namespace Bsg.GameSettings.Json;

public static class JsonMigrationUtils
{

	private static int Clamp(int value, int min, int max) { }

	public static void ConvertIndexToObject(JObject data, string name, IReadOnlyList variants) { }

	public static void ConvertIndexToValue(JObject data, string name, IReadOnlyList variants) { }

	public static void MakeIntOffset(JObject data, string name, int offset) { }

	public static void RenameProperty(JObject data, string oldName, string newName) { }

	public static void SetPropertyValue(JObject data, string name, T newValue) { }

}

