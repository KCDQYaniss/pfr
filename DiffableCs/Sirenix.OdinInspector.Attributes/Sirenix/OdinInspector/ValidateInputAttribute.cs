namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True, Inherited = True)]
[Conditional("UNITY_EDITOR")]
[DontApplyToListElements]
public sealed class ValidateInputAttribute : Attribute
{
	public string DefaultMessage; //Field offset: 0x10
	public string Condition; //Field offset: 0x18
	public InfoMessageType MessageType; //Field offset: 0x20
	public bool IncludeChildren; //Field offset: 0x24
	public bool ContinuousValidationCheck; //Field offset: 0x25

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the ContinuousValidationCheck member instead.")]
	public bool ContiniousValidationCheck
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Condition member instead.", False)]
	public string MemberName
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public ValidateInputAttribute(string condition, string defaultMessage = null, InfoMessageType messageType = 3) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Rejecting invalid input is no longer supported. Use the other constructor instead.", True)]
	public ValidateInputAttribute(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput) { }

	public bool get_ContiniousValidationCheck() { }

	public string get_MemberName() { }

	public void set_ContiniousValidationCheck(bool value) { }

	public void set_MemberName(string value) { }

}

