namespace System.Xml.Schema;

internal class BinaryFacetsChecker : FacetsChecker
{

	public BinaryFacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

