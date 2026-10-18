namespace Comfort.Common;

public class Operation : AbstractOperation
{
	private bool ; //Field offset: 0x28
	private string ; //Field offset: 0x30

	public virtual bool Completed
	{
		 get { } //Length: 18
	}

	public virtual string Error
	{
		 get { } //Length: 76
		 set { } //Length: 203
	}

	public virtual bool Failed
	{
		 get { } //Length: 9
	}

	public virtual bool Succeed
	{
		 get { } //Length: 5
		 set { } //Length: 173
	}

	public Operation() { }

	public static Operation FailedOperation(string error) { }

	public virtual bool get_Completed() { }

	public virtual string get_Error() { }

	public virtual bool get_Failed() { }

	public virtual bool get_Succeed() { }

	protected virtual void set_Error(string value) { }

	protected virtual void set_Succeed(bool value) { }

	public static Operation SucceedOperation() { }

}

