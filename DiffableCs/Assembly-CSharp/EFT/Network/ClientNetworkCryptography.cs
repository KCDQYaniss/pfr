namespace EFT.Network;

public class ClientNetworkCryptography : BaseNetworkCryptography
{

	public ClientNetworkCryptography(bool encryptionEnabled, bool decryptionEnabled) { }

	public virtual void Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength) { }

	public virtual void Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength) { }

}

