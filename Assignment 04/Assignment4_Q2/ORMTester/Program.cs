using System.Linq;
using System.Reflection;
using AttributesLib;

namespace ORMTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string queryfile = "F:\\data\\C-DAC\\MyGitData\\gfsdds\\NET\\Classwork_Solution\\query.sql";

            string path ="F:\\data\\C-DAC\\MyGitData\\gfsdds\\NET\\Assignment_Workspace\\EntityLib\\bin\\Debug\\net6.0\\EntityLib.dll";
            Assembly assembly = Assembly.LoadFrom(path);

            Type[] types = assembly.GetTypes();

            #region Get the object's property array
            //foreach (Type type in types)
            //{
            //    PropertyInfo[] propertyInfo = type.GetProperties();
            //    foreach (PropertyInfo property in propertyInfo)
            //    {
            //        Console.WriteLine(property.Name);
            //    }

            //}
            #endregion

            foreach (Type t in types)
            {

                string query = "";
                Attribute[] attributes = t.GetCustomAttributes().ToArray();
                foreach (Attribute a in attributes)
                {
                    if (a is Table)
                    {
                        Table table = (Table)a;
                        query = query + "create table " + table.TableName + "( ";
                    }
                }

                PropertyInfo[] propertyInfos = t.GetProperties();
                foreach (PropertyInfo p in propertyInfos)
                {
                    Attribute[] ColAttribute = p.GetCustomAttributes().ToArray();

                    foreach (Attribute a in ColAttribute)
                    {
                        if (a is Column)
                        {
                            Column column = (Column)a;
                            query = query + column.ColumnName + " " + column.ColumnType + ",";
                            break;
                        }
                    }

                }

                query = query.TrimEnd(',');
                query = query + ");";




                FileStream fileStream = null;   
                if (File.Exists(queryfile))
                {
                    fileStream = new FileStream(queryfile, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fileStream = new FileStream(queryfile, FileMode.OpenOrCreate, FileAccess.Write);
                }

                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(query);
                writer.Close();


                writer = null;
                fileStream = null;


                Console.WriteLine("Done writing query");




            }



        }
    }
}
