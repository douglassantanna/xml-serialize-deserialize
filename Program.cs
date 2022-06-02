using System;
using System.Xml.Serialization;
using xml_serialize_deserialize;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // DeserializeXmlFileToObject();
            // DeserializeXmlFileToList();
            // DeserializeXmlFileToList();
            // SerializeListToXmlFile();
            // SerializeObjectToXmlFile();
            SerializeObjectToXmlString();
            // Console.ReadKey();
        }
        private static void SerializeObjectToXmlString()
        {
            Pessoa pessoa = new()
            {
                Nome = "Douglas",
                Email = "douglas@douglas.com",
                Idade = 28,
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            var xmlSerializer = new XmlSerializer(typeof(Pessoa));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, pessoa);
                var xmlContent = writer.ToString();
                System.Console.WriteLine(xmlContent);
                DeserializeXmlStringToObject(xmlContent);
            }
        }
        private static void DeserializeXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Pessoa));
            using (var reader = new StringReader(xmlString))
            {
                var pessoa = (Pessoa)xmlSerializer.Deserialize(reader);
            }
        }
        private static void SerializeObjectToXmlFile()
        {
            Pessoa pessoa = new()
            {
                Nome = "Douglas",
                Email = "douglas@douglas.com",
                Idade = 28,
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            var xmlSerializer = new XmlSerializer(typeof(Pessoa));
            using (var writer = new StreamWriter(@"C:\Clouddata\POCS\xml-serialize-deserialize\arquivos-xml\exemplo01.xml"))
            {
                xmlSerializer.Serialize(writer, pessoa);
            }
        }
        private static void SerializeListToXmlFile()
        {
            var listaDePessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    Nome = "Douglas",
                    Email = "douglas@douglas.com",
                    Idade = 28,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                },
                new Pessoa
                {
                    Nome = "Davi",
                    Email = "davi@davi.com",
                    Idade = 09,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                },
                new Pessoa
                {
                    Nome = "João",
                    Email = "joao@joao.com",
                    Idade = 54,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                },
                new Pessoa
                {
                    Nome = "Eliane",
                    Email = "eliane@eliane.com",
                    Idade = 50,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                },
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Pessoa>));
            using (var writer = new StreamWriter(@"C:\Clouddata\POCS\xml-serialize-deserialize\arquivos-xml\exemplo02.xml"))
            {
                xmlSerializer.Serialize(writer, listaDePessoas);
            }
        }
        private static void DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Pessoa>));
            using (var reader = new StreamReader(@"C:\Clouddata\POCS\xml-serialize-deserialize\arquivos-xml\exemplo02.xml"))
            {
                var pessoas = (List<Pessoa>)xmlSerializer.Deserialize(reader);
            }
        }
        private static void DeserializeXmlFileToObject()
        {
            var xmlSerializer = new XmlSerializer(typeof(Pessoa));
            using (var reader = new StreamReader(@"C:\Clouddata\POCS\xml-serialize-deserialize\arquivos-xml\exemplo01.xml"))
            {
                var pessoas = (Pessoa)xmlSerializer.Deserialize(reader);
            }
        }
    }
}