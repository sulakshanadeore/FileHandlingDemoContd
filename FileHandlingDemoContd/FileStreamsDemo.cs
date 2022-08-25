using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace FileHandlingDemoContd
{
    class FileStreamsDemo
    {
        static void Main(string[] args)
        {
            //FileMode and fileAccess Grants are not available with File class, so we use FileStream Class
            //Create---Write
            //Truncate--Write
            //createNew--Write
            //Open---Read
            //OpenOrCreate---Read/Write
            //Append--Write
            //StreamWriter writes to the filestream
            //Nonstatic--StreamWriter
            //StreamWriter---inherits from TextWriter
            //StreamReader=----inherits from TextReader

            //TextFiles
            //WorkingWithTextFileCreation();
            //ReadTextFile();
            ///////////////////////////////////////

            //BinaryWriter
            //BinaryREader
            //BinaryFileCreate();
            //BinaryFileRead();


            //FileStream fs = new FileStream("emp.xml", FileMode.Create, FileAccess.Write);
            //createXMLFile();

            FileStream fs = new FileStream("emp.xml", FileMode.Open, FileAccess.Read
                );
            XmlTextReader xr = new XmlTextReader(fs);
            while (xr.Read())
            {
                switch (xr.NodeType)
                {
                    case XmlNodeType.None:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Element:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Attribute:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Entity:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Document:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine(xr.Value);

                        break;
                    case XmlNodeType.DocumentFragment:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Notation:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.Whitespace:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.EndEntity:
                        Console.WriteLine(xr.Value);
                        break;
                    case XmlNodeType.XmlDeclaration:
                        Console.WriteLine(xr.Value);
                        break;
                    
                }
            }
            xr.Close();
            xr.Dispose();
            fs.Close();
            fs.Dispose();




            //xmlTextReader/xmlTextWriter

            Console.ReadLine();




        }

        private static void createXMLFile()
        {
            XmlWriter xw = XmlWriter.Create("emp.xml");
            xw.WriteStartDocument();
            xw.WriteStartElement("empdata");
            xw.WriteAttributeString("city", "Pune");
            xw.WriteElementString("empno", "1");
            xw.WriteElementString("empname", "ABC");
            xw.WriteElementString("deptno", "10");
            xw.WriteComment("This is a comment");


            xw.WriteEndElement();
            xw.WriteEndDocument();
            xw.Close();
            xw.Dispose();
        }

        private static void BinaryFileRead()
        {
            FileStream fs = new FileStream("demo2.bin", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int i = br.ReadInt32();
            Console.WriteLine(i);
            br.Close();
            br.Dispose();
            fs.Close();
            fs.Dispose();
        }

        private static void BinaryFileCreate()
        {
            FileStream fs = new FileStream("demo2.bin", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(224234);
            bw.Flush();


            fs.Flush();
            bw.Close();
            fs.Close();
            bw.Dispose();
            fs.Dispose();
        }

        private static void ReadTextFile()
        {
            FileStream fs = new FileStream("demo1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string contents = sr.ReadToEnd();
            Console.WriteLine(contents);

            sr.Close();
            sr.Dispose();
            fs.Close();
            fs.Dispose();
        }

        private static void WorkingWithTextFileCreation()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("demo1.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.Write("This is a file created using FileStream and written using Stream Writer");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Flush();//clears the buffer
                fs.Flush();
                sw.Close();//closes the resource
                fs.Close();
                sw.Dispose();//disposes the objects
                fs.Dispose();
            }
        }
    }
}
