namespace EFT;

public sealed class CharacterSelectionDataResponse : Dictionary
{

	public CharacterSelectionDataResponse() { }

	public static CharacterSelectionDataResponse BuildCharacterSelectionMockData() { }

	public bool HasOnlyEmptyProfileSlots() { }

	private static PlayerVisualRepresentation LoadPlayerVisualRepresentation(string localProfileName) { }

	public bool TryGetInRaidProfile(out EGameMode gameMode, out CharacterSelectionProfileData profileData) { }

}

