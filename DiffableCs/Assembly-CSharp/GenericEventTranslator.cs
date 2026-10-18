//Type is in global namespace

[Obfuscation(Exclude = True)]
public class GenericEventTranslator : MonoBehaviour
{
	public Action OnSoundBankPlay; //Field offset: 0x20

	public GenericEventTranslator() { }

	private void PlaySoundBank(string bankType) { }

}

