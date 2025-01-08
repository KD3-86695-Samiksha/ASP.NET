using System.Data;

namespace AttributesLib
{
   
    public class Table : Attribute
    {
        
        private string _TableName;

        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }

    }

    public class Column : Attribute
    {
        private string _ColumnName;

        public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }

        private string _ColumnType;

        public string ColumnType
        {
            get { return _ColumnType; }
            set { _ColumnType = value; }
        }



    }

    public class KeyColumn : Attribute
    {
        private string keyType;

        public string KeyType
        {
            get { return keyType; }
            set { keyType = value; }
        }
    }

    public class UnMapped : Attribute
    {
        private bool include;

        public bool Include
        {
            get { return include; }
            set { include = value; }
        }

    }
}
