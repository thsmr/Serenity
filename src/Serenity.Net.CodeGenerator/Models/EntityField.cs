﻿namespace Serenity.CodeGenerator
{
    public class EntityField
    {
        public string FieldType { get; set; }
        public string DataType { get; set; }
        public string TSType { get; set; }
        public string Ident { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Flags { get; set; }
        public string PKSchema { get; set; }
        public string PKTable { get; set; }
        public string PKColumn { get; set; }
        public string ForeignJoinAlias { get; set; }
        public bool Insertable { get; set; }
        public bool Updatable { get; set; }
        public bool IsValueType { get; set; }
        public int? Size { get; set; }
        public int Scale { get; set; }
        public string TextualField { get; set; }
        public string Attributes { get; set; }
        public string ColAttributes { get; set; }
        public string Expression { get; set; }

        public string TSEditorType
        {
            get
            {
                return FieldType switch
                {
                    "System.Int32" or "System.Int16" or "System.Int64" => "IntegerEditor",
                    "System.Single" or "System.Double" or "System.Decimal" => "DecimalEditor",
                    "System.DateTime" => "DateEditor",
                    "System.Boolean" => "BooleanEditor",
                    _ => "StringEditor",
                };
            }
        }

        public string PropertyType
        {
            get { return IsValueType ? DataType + "?" : DataType; }
        }
    }
}