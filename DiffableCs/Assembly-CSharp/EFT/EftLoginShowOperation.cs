namespace EFT;

public sealed class EftLoginShowOperation : LoginShowOperation
{

	public EftLoginShowOperation() { }

	public static EftLoginShowOperation Execute(IClientBackEnd backend, Login login) { }

	protected virtual ILoginScreenController GetLoginScreenController(string login, string password, bool savePassword) { }

	protected virtual IValidateDeviceIdScreenController GetLoginScreenController() { }

}

