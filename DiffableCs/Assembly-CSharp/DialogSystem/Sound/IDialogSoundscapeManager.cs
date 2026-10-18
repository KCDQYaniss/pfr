namespace DialogSystem.Sound;

public interface IDialogSoundscapeManager
{

	public void Initialize() { }

	public void Release(bool allowFadeOut = false, Action onCompleted = null) { }

}

