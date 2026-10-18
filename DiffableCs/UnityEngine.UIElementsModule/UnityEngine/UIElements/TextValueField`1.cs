namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class TextValueField`1 : TextInputBaseField, IValueField
{
	internal abstract class TextValueInput : TextInputBase
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private string <formatString>k__BackingField; //Field offset: 0x0

		protected abstract string allowedCharacters
		{
			 get { } //Length: 0
		}

		public string formatString
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 82
		}

		private TextValueField textValueFieldParent
		{
			private get { } //Length: 136
		}

		protected TextValueInput() { }

		internal virtual bool AcceptCharacter(char c) { }

		public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

		protected abstract string get_allowedCharacters() { }

		[CompilerGenerated]
		public string get_formatString() { }

		private TextValueField get_textValueFieldParent() { }

		[CompilerGenerated]
		public void set_formatString(string value) { }

		public void StartDragging() { }

		public void StopDragging() { }

		protected virtual TValueType StringToValue(string str) { }

		protected abstract string ValueToString(TValueType value) { }

	}

	private BaseFieldMouseDragger m_Dragger; //Field offset: 0x0
	internal bool m_UpdateTextFromValue; //Field offset: 0x0
	private bool m_ForceUpdateDisplay; //Field offset: 0x0

	public string formatString
	{
		 get { } //Length: 136
	}

	private TextValueInput textValueInput
	{
		private get { } //Length: 137
	}

	public virtual TValueType value
	{
		 get { } //Length: 27
		 set { } //Length: 41
	}

	protected TextValueField`1(string label, int maxLength, TextValueInput textValueInput) { }

	protected void AddLabelDragger() { }

	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	internal override bool CanTryParse(string textString) { }

	private void EnableLabelDragger(bool enable) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(BlurEvent), typeof(FocusEvent)})]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	public string get_formatString() { }

	private TextValueInput get_textValueInput() { }

	public virtual TValueType get_value() { }

	private void OnIsReadOnlyChanged(bool newValue) { }

	internal virtual void OnViewDataReady() { }

	internal virtual void RegisterEditingCallbacks() { }

	public virtual void set_value(TValueType value) { }

	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	public override void StartDragging() { }

	public override void StopDragging() { }

	internal virtual void UnregisterEditingCallbacks() { }

	internal virtual void UpdateTextFromValue() { }

	internal virtual void UpdateValueFromText() { }

}

