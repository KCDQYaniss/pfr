namespace EFT;

public interface ICaptchaHandler
{

	public void Activate() { }

	public void Deactivate() { }

	public Task RequestCaptcha() { }

	public void RequestCaptcha(object operation, Callback callback) { }

}

