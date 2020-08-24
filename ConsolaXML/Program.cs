using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolaXML
{
    class Program
    {
        static void Main(string[] args)
        {


            XmlDocument document = new XmlDocument();
            XmlElement element = document.CreateElement("personas");
            document.AppendChild(element);
            InsertarPersona(document, element, "personas.xml", new Persona("Pedro", "Gonzalez", "638563120", 36));
            InsertarPersona(document, element, "personas.xml", new Persona("Marta", "Perez", "629429104", 28));
            InsertarPersona(document, element, "personas.xml", new Persona("Carlos", "Castillo", "543097125", 48));

            XmlReader xmlReader = new XmlTextReader("personas.xml");
            List<Persona> personas = new List<Persona>();
            while (xmlReader.ReadToFollowing("persona"))
            {
                XmlReader subReader = xmlReader.ReadSubtree();
                Persona persona = new Persona();
                subReader.Read();
                String telefono = subReader.GetAttribute("telefono");
                persona.Telefono = telefono;
                subReader.ReadToFollowing("nombre");
                subReader.Read();
                String nombre = subReader.Value;
                persona.Nombre = nombre;
                subReader.ReadToFollowing("apellidos");
                subReader.Read();
                String apellidos = subReader.Value;
                persona.Apellidos = apellidos;
                subReader.ReadToFollowing("edad");
                subReader.Read();
                String edad = subReader.Value;
                persona.Edad = Convert.ToInt32(edad);
                personas.Add(persona);
            }
            foreach (Persona p in personas)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }

        private static void InsertarPersona(XmlDocument documento, XmlElement root, string archivo, Persona persona)
        {

            XmlElement elemento = documento.CreateElement("persona");
            XmlElement Enombre = documento.CreateElement("nombre");
            XmlElement Eapellidos = documento.CreateElement("apellidos");
            XmlElement Eedad = documento.CreateElement("edad");


            XmlAttribute atributo = documento.CreateAttribute("telefono");
            atributo.InnerText = persona.Telefono;

            elemento.Attributes.Append(atributo);
            elemento.AppendChild(Enombre);
            elemento.AppendChild(Eapellidos);
            elemento.AppendChild(Eedad);
            Enombre.InnerText = persona.Nombre;
            Eapellidos.InnerText = persona.Apellidos;
            Eedad.InnerText = persona.Edad.ToString();
            

            root.AppendChild(elemento);
            XmlWriter escritor = new XmlTextWriter(archivo, null);
            documento.Save(escritor);
            escritor.Close();
        }
    }
}
