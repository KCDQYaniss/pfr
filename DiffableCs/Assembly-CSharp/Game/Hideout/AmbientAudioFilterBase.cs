namespace Game.Hideout;

public abstract class AmbientAudioFilterBase : MonoBehaviour
{

	protected AmbientAudioFilterBase() { }

	public abstract void Apply() { }

	public abstract void ResetToDefault() { }

}

