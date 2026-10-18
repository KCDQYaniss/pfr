namespace Audio.Data;

public abstract class SoundBankContainerBase`1 : ScriptableObject
{

	protected SoundBankContainerBase`1() { }

	public abstract bool TryGetBank(T soundType, out SoundBankWithSettings bank) { }

}

