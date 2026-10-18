namespace Comfort.Net;

public interface IValidator
{

	public ConnectionValidatorStatus Status
	{
		 get { } //Length: 0
	}

	public void Approve(ConnectionAcceptor acceptor) { }

	public void Ban() { }

	public ConnectionValidatorStatus get_Status() { }

	public void Reject(ErrorCode code) { }

}

