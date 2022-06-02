using System.Xml.Serialization;

namespace xml_serialize_deserialize;

[Serializable]
// [XmlRoot("DetalhesPessoais")]
public class Pessoa
{
    // [XmlElement("PessoaNome")]
    public string? Nome { get; set; }

    // [XmlElement("PessoaEmail")]
    public string? Email { get; set; }

    // [XmlElement("PessoaIdade")]
    public int Idade { get; set; }

    // [XmlIgnore]
    public DateTime DataCadastro { get; set; }

    // [XmlAttribute("Ativo")]
    public bool Ativo { get; set; }
}
