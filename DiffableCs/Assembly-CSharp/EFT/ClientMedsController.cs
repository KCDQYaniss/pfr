namespace EFT;

internal sealed class ClientMedsController : MedsController
{

	public ClientMedsController() { }

	internal static ClientMedsController Create(ClientPlayer player, Item item, OneAndList bodyParts, float amount, int animationVariant) { }

	internal static Task CreateAsync(ClientPlayer player, string itemId, OneAndList bodyParts, float amount, int animationVariant) { }

}

