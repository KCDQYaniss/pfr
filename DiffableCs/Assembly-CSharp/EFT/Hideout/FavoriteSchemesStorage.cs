namespace EFT.Hideout;

public static class FavoriteSchemesStorage
{
	private static List _favoriteCrafts; //Field offset: 0x0

	private static FavoriteSchemesStorage() { }

	public static void AddFavoriteScheme(string schemeId) { }

	public static void DeleteFavoriteScheme(string schemeId) { }

	public static void Load(bool allowMigration = true) { }

	private static void MigrateFavoriteSchemesToProfile() { }

	private static void Save() { }

	public static bool TryGetFavoriteIndex(string schemeId, out int index) { }

}

