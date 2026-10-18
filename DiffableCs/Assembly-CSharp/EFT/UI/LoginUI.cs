namespace EFT.UI;

public sealed class LoginUI : MonoBehaviourSingleton
{
	public EftLoginScreen LoginScreen; //Field offset: 0x20
	public EftValidateDeviceIdScreen ValidateDeviceIdScreen; //Field offset: 0x28
	public EftWelcomeScreen WelcomeScreen; //Field offset: 0x30
	public EftAccountSideSelectionScreen SideSelectionScreen; //Field offset: 0x38
	public RestorePasswordScreen RestorePasswordScreen; //Field offset: 0x40
	public ProfileLoadingScreen ProfileLoadingScreen; //Field offset: 0x48

	public LoginUI() { }

	public virtual void Awake() { }

	public virtual void OnDestroy() { }

}

