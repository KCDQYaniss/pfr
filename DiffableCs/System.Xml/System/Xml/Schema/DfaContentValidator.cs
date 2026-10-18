namespace System.Xml.Schema;

internal sealed class DfaContentValidator : ContentValidator
{
	private int[][] transitionTable; //Field offset: 0x18
	private SymbolsDictionary symbols; //Field offset: 0x20

	internal DfaContentValidator(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	public virtual bool CompleteValidation(ValidationState context) { }

	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	public virtual void InitValidation(ValidationState context) { }

	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

