namespace Comfort.Common;

public class Operation`1 : AbstractOperation, IOperation, IOperation, IEnumerator
{
	private Result ; //Field offset: 0x0

	public virtual bool Completed
	{
		 get { } //Length: 103
	}

	public virtual string Error
	{
		 get { } //Length: 76
		 set { } //Length: 296
	}

	public virtual bool Failed
	{
		 get { } //Length: 56
	}

	public override T Result
	{
		 get { } //Length: 5
		 set { } //Length: 254
	}

	public virtual bool Succeed
	{
		 get { } //Length: 103
		 set { } //Length: 101
	}

	public Operation`1() { }

	public Operation`1(T result) { }

	public Operation`1(ref Result result) { }

	public virtual bool get_Completed() { }

	public virtual string get_Error() { }

	public virtual bool get_Failed() { }

	public override T get_Result() { }

	public virtual bool get_Succeed() { }

	public static Result op_Implicit(Operation operation) { }

	protected virtual void set_Error(string value) { }

	protected void set_Result(T value) { }

	protected virtual void set_Succeed(bool value) { }

}

