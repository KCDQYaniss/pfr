namespace FastAnimatorSystem;

public class AnimatorValue : IDisposable
{
	internal class AnimatorValueException : Exception
	{

		public AnimatorValueException() { }

		public AnimatorValueException(string message) { }

	}

	internal enum EAnimatorValueType
	{
		Undefined = -1,
		Int = 0,
		Float = 1,
		Boolean = 2,
		Trigger = 3,
	}

	private bool _boolValue; //Field offset: 0x10
	private float _floatValue; //Field offset: 0x14
	private int _intValue; //Field offset: 0x18
	public readonly EAnimatorValueType ValueType; //Field offset: 0x1C

	public AnimatorValue(EAnimatorValueType valueType) { }

	protected override void Dispose(bool disposing) { }

	public override void Dispose() { }

	public bool GetBoolValue() { }

	public float GetFloatValue() { }

	public int GetIntValue() { }

	public string GetStringValue() { }

	public void SetValue(float value) { }

	public void SetValue(int value) { }

	public void SetValue(bool value) { }

	public void SetValue(string value) { }

	public virtual string ToString() { }

	protected override void ValueChanged() { }

	private bool WrongGetBoolValueDelegate() { }

	private float WrongGetFloatValueDelegate() { }

	private int WrongGetIntValueDelegate() { }

	private void WrongSetBoolValueDelegate(bool value) { }

	private void WrongSetFloatValueDelegate(float value) { }

	private void WrongSetIntValueDelegate(int value) { }

}

