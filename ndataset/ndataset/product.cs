﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34011
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный код был создан с помощью xsd, версия=4.0.30319.17929.
// 


/// <summary>
///Represents a strongly typed in-memory cache of data.
///</summary>
[global::System.Serializable()]
[global::System.ComponentModel.DesignerCategoryAttribute("code")]
[global::System.ComponentModel.ToolboxItem(true)]
[global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
[global::System.Xml.Serialization.XmlRootAttribute("AutoLot")]
[global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
public partial class AutoLot : global::System.Data.DataSet {
    
    private ProductDataTable tableProduct;
    
    private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public AutoLot() {
        this.BeginInit();
        this.InitClass();
        global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += schemaChangedHandler;
        base.Relations.CollectionChanged += schemaChangedHandler;
        this.EndInit();
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected AutoLot(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
            base(info, context, false) {
        if ((this.IsBinarySerialized(info, context) == true)) {
            this.InitVars(false);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler1;
            this.Relations.CollectionChanged += schemaChangedHandler1;
            return;
        }
        string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
        if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
            global::System.Data.DataSet ds = new global::System.Data.DataSet();
            ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            if ((ds.Tables["Product"] != null)) {
                base.Tables.Add(new ProductDataTable(ds.Tables["Product"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        else {
            this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
        }
        this.GetSerializationData(info, context);
        global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += schemaChangedHandler;
        this.Relations.CollectionChanged += schemaChangedHandler;
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [global::System.ComponentModel.Browsable(false)]
    [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
    public ProductDataTable Product {
        get {
            return this.tableProduct;
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [global::System.ComponentModel.BrowsableAttribute(true)]
    [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
    public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
        get {
            return this._schemaSerializationMode;
        }
        set {
            this._schemaSerializationMode = value;
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public new global::System.Data.DataTableCollection Tables {
        get {
            return base.Tables;
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
    public new global::System.Data.DataRelationCollection Relations {
        get {
            return base.Relations;
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void InitializeDerivedDataSet() {
        this.BeginInit();
        this.InitClass();
        this.EndInit();
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override global::System.Data.DataSet Clone() {
        AutoLot cln = ((AutoLot)(base.Clone()));
        cln.InitVars();
        cln.SchemaSerializationMode = this.SchemaSerializationMode;
        return cln;
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeTables() {
        return false;
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeRelations() {
        return false;
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
        if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
            this.Reset();
            global::System.Data.DataSet ds = new global::System.Data.DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Product"] != null)) {
                base.Tables.Add(new ProductDataTable(ds.Tables["Product"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        else {
            this.ReadXml(reader);
            this.InitVars();
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
        global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
        this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
        stream.Position = 0;
        return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars() {
        this.InitVars(true);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars(bool initTable) {
        this.tableProduct = ((ProductDataTable)(base.Tables["Product"]));
        if ((initTable == true)) {
            if ((this.tableProduct != null)) {
                this.tableProduct.InitVars();
            }
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass() {
        this.DataSetName = "AutoLot";
        this.Prefix = "";
        this.Namespace = "http://tempuri.org/XMLSchemal.xsd";
        this.Locale = new global::System.Globalization.CultureInfo("");
        this.EnforceConstraints = true;
        this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        this.tableProduct = new ProductDataTable();
        base.Tables.Add(this.tableProduct);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeProduct() {
        return false;
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
        if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
            this.InitVars();
        }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
        AutoLot ds = new AutoLot();
        global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
        global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
        global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
        any.Namespace = ds.Namespace;
        sequence.Items.Add(any);
        type.Particle = sequence;
        global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
        if (xs.Contains(dsSchema.TargetNamespace)) {
            global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
            global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
            try {
                global::System.Xml.Schema.XmlSchema schema = null;
                dsSchema.Write(s1);
                for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                    schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                    s2.SetLength(0);
                    schema.Write(s2);
                    if ((s1.Length == s2.Length)) {
                        s1.Position = 0;
                        s2.Position = 0;
                        for (; ((s1.Position != s1.Length) 
                                    && (s1.ReadByte() == s2.ReadByte())); ) {
                            ;
                        }
                        if ((s1.Position == s1.Length)) {
                            return type;
                        }
                    }
                }
            }
            finally {
                if ((s1 != null)) {
                    s1.Close();
                }
                if ((s2 != null)) {
                    s2.Close();
                }
            }
        }
        xs.Add(dsSchema);
        return type;
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void ProductRowChangeEventHandler(object sender, ProductRowChangeEvent e);
    
    /// <summary>
    ///Represents the strongly named DataTable class.
    ///</summary>
    [global::System.Serializable()]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
    public partial class ProductDataTable : global::System.Data.DataTable, global::System.Collections.IEnumerable {
        
        private global::System.Data.DataColumn columnCarID;
        
        private global::System.Data.DataColumn columnMake;
        
        private global::System.Data.DataColumn columnColor;
        
        private global::System.Data.DataColumn columnPetName;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductDataTable() {
            this.TableName = "Product";
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal ProductDataTable(global::System.Data.DataTable table) {
            this.TableName = table.TableName;
            if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                this.CaseSensitive = table.CaseSensitive;
            }
            if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                this.Locale = table.Locale;
            }
            if ((table.Namespace != table.DataSet.Namespace)) {
                this.Namespace = table.Namespace;
            }
            this.Prefix = table.Prefix;
            this.MinimumCapacity = table.MinimumCapacity;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected ProductDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context) {
            this.InitVars();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn CarIDColumn {
            get {
                return this.columnCarID;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn MakeColumn {
            get {
                return this.columnMake;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn ColorColumn {
            get {
                return this.columnColor;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataColumn PetNameColumn {
            get {
                return this.columnPetName;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        public int Count {
            get {
                return this.Rows.Count;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductRow this[int index] {
            get {
                return ((ProductRow)(this.Rows[index]));
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event ProductRowChangeEventHandler ProductRowChanging;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event ProductRowChangeEventHandler ProductRowChanged;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event ProductRowChangeEventHandler ProductRowDeleting;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public event ProductRowChangeEventHandler ProductRowDeleted;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void AddProductRow(ProductRow row) {
            this.Rows.Add(row);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductRow AddProductRow(string Make, string Color, string PetName) {
            ProductRow rowProductRow = ((ProductRow)(this.NewRow()));
            object[] columnValuesArray = new object[] {
                    null,
                    Make,
                    Color,
                    PetName};
            rowProductRow.ItemArray = columnValuesArray;
            this.Rows.Add(rowProductRow);
            return rowProductRow;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual global::System.Collections.IEnumerator GetEnumerator() {
            return this.Rows.GetEnumerator();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataTable Clone() {
            ProductDataTable cln = ((ProductDataTable)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataTable CreateInstance() {
            return new ProductDataTable();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars() {
            this.columnCarID = base.Columns["CarID"];
            this.columnMake = base.Columns["Make"];
            this.columnColor = base.Columns["Color"];
            this.columnPetName = base.Columns["PetName"];
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass() {
            this.columnCarID = new global::System.Data.DataColumn("CarID", typeof(int), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnCarID);
            this.columnMake = new global::System.Data.DataColumn("Make", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnMake);
            this.columnColor = new global::System.Data.DataColumn("Color", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnColor);
            this.columnPetName = new global::System.Data.DataColumn("PetName", typeof(string), null, global::System.Data.MappingType.Element);
            base.Columns.Add(this.columnPetName);
            this.columnCarID.AutoIncrement = true;
            this.columnCarID.AllowDBNull = false;
            this.columnCarID.ReadOnly = true;
            this.columnCarID.Namespace = "";
            this.columnMake.AllowDBNull = false;
            this.columnMake.Namespace = "";
            this.columnColor.AllowDBNull = false;
            this.columnColor.Namespace = "";
            this.columnPetName.AllowDBNull = false;
            this.columnPetName.Namespace = "";
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductRow NewProductRow() {
            return ((ProductRow)(this.NewRow()));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
            return new ProductRow(builder);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Type GetRowType() {
            return typeof(ProductRow);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.ProductRowChanged != null)) {
                this.ProductRowChanged(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.ProductRowChanging != null)) {
                this.ProductRowChanging(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.ProductRowDeleted != null)) {
                this.ProductRowDeleted(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.ProductRowDeleting != null)) {
                this.ProductRowDeleting(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public void RemoveProductRow(ProductRow row) {
            this.Rows.Remove(row);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            AutoLot ds = new AutoLot();
            global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
            any1.Namespace = "http://www.w3.org/2001/XMLSchema";
            any1.MinOccurs = new decimal(0);
            any1.MaxOccurs = decimal.MaxValue;
            any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
            sequence.Items.Add(any1);
            global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
            any2.MinOccurs = new decimal(1);
            any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
            sequence.Items.Add(any2);
            global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
            attribute1.Name = "namespace";
            attribute1.FixedValue = ds.Namespace;
            type.Attributes.Add(attribute1);
            global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
            attribute2.Name = "tableTypeName";
            attribute2.FixedValue = "ProductDataTable";
            type.Attributes.Add(attribute2);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
    }
    
    /// <summary>
    ///Represents strongly named DataRow class.
    ///</summary>
    public partial class ProductRow : global::System.Data.DataRow {
        
        private ProductDataTable tableProduct;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal ProductRow(global::System.Data.DataRowBuilder rb) : 
                base(rb) {
            this.tableProduct = ((ProductDataTable)(this.Table));
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int CarID {
            get {
                return ((int)(this[this.tableProduct.CarIDColumn]));
            }
            set {
                this[this.tableProduct.CarIDColumn] = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string Make {
            get {
                return ((string)(this[this.tableProduct.MakeColumn]));
            }
            set {
                this[this.tableProduct.MakeColumn] = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string Color {
            get {
                return ((string)(this[this.tableProduct.ColorColumn]));
            }
            set {
                this[this.tableProduct.ColorColumn] = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public string PetName {
            get {
                return ((string)(this[this.tableProduct.PetNameColumn]));
            }
            set {
                this[this.tableProduct.PetNameColumn] = value;
            }
        }
    }
    
    /// <summary>
    ///Row event argument class
    ///</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class ProductRowChangeEvent : global::System.EventArgs {
        
        private ProductRow eventRow;
        
        private global::System.Data.DataRowAction eventAction;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductRowChangeEvent(ProductRow row, global::System.Data.DataRowAction action) {
            this.eventRow = row;
            this.eventAction = action;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ProductRow Row {
            get {
                return this.eventRow;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public global::System.Data.DataRowAction Action {
            get {
                return this.eventAction;
            }
        }
    }
}
