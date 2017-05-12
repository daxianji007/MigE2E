//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30128.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 3/15/2010 12:17:39 PM
namespace AdventureWorksSalesEditor.AdventureWorksService
{
    
    /// <summary>
    /// There are no comments for AdventureWorksLTEntities in the schema.
    /// </summary>
    public partial class AdventureWorksLTEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new AdventureWorksLTEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public AdventureWorksLTEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("AdventureWorksLTModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("AdventureWorksSalesEditor.AdventureWorksService", typeName.Substring(21)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("AdventureWorksSalesEditor.AdventureWorksService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("AdventureWorksLTModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for SalesOrderHeaders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<SalesOrderHeader> SalesOrderHeaders
        {
            get
            {
                if ((this._SalesOrderHeaders == null))
                {
                    this._SalesOrderHeaders = base.CreateQuery<SalesOrderHeader>("SalesOrderHeaders");
                }
                return this._SalesOrderHeaders;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<SalesOrderHeader> _SalesOrderHeaders;
        /// <summary>
        /// There are no comments for SalesOrderHeaders in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToSalesOrderHeaders(SalesOrderHeader salesOrderHeader)
        {
            base.AddObject("SalesOrderHeaders", salesOrderHeader);
        }
    }
    /// <summary>
    /// There are no comments for AdventureWorksLTModel.SalesOrderHeader in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SalesOrderID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("SalesOrderHeaders")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("SalesOrderID")]
    public partial class SalesOrderHeader : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesOrderHeader object.
        /// </summary>
        /// <param name="salesOrderID">Initial value of SalesOrderID.</param>
        /// <param name="revisionNumber">Initial value of RevisionNumber.</param>
        /// <param name="orderDate">Initial value of OrderDate.</param>
        /// <param name="dueDate">Initial value of DueDate.</param>
        /// <param name="status">Initial value of Status.</param>
        /// <param name="onlineOrderFlag">Initial value of OnlineOrderFlag.</param>
        /// <param name="salesOrderNumber">Initial value of SalesOrderNumber.</param>
        /// <param name="customerID">Initial value of CustomerID.</param>
        /// <param name="shipMethod">Initial value of ShipMethod.</param>
        /// <param name="subTotal">Initial value of SubTotal.</param>
        /// <param name="taxAmt">Initial value of TaxAmt.</param>
        /// <param name="freight">Initial value of Freight.</param>
        /// <param name="totalDue">Initial value of TotalDue.</param>
        /// <param name="rowguid">Initial value of rowguid.</param>
        /// <param name="modifiedDate">Initial value of ModifiedDate.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static SalesOrderHeader CreateSalesOrderHeader(int salesOrderID, byte revisionNumber, global::System.DateTime orderDate, global::System.DateTime dueDate, byte status, bool onlineOrderFlag, string salesOrderNumber, int customerID, string shipMethod, decimal subTotal, decimal taxAmt, decimal freight, decimal totalDue, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            SalesOrderHeader salesOrderHeader = new SalesOrderHeader();
            salesOrderHeader.SalesOrderID = salesOrderID;
            salesOrderHeader.RevisionNumber = revisionNumber;
            salesOrderHeader.OrderDate = orderDate;
            salesOrderHeader.DueDate = dueDate;
            salesOrderHeader.Status = status;
            salesOrderHeader.OnlineOrderFlag = onlineOrderFlag;
            salesOrderHeader.SalesOrderNumber = salesOrderNumber;
            salesOrderHeader.CustomerID = customerID;
            salesOrderHeader.ShipMethod = shipMethod;
            salesOrderHeader.SubTotal = subTotal;
            salesOrderHeader.TaxAmt = taxAmt;
            salesOrderHeader.Freight = freight;
            salesOrderHeader.TotalDue = totalDue;
            salesOrderHeader.rowguid = rowguid;
            salesOrderHeader.ModifiedDate = modifiedDate;
            return salesOrderHeader;
        }
        /// <summary>
        /// There are no comments for Property SalesOrderID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int SalesOrderID
        {
            get
            {
                return this._SalesOrderID;
            }
            set
            {
                this.OnSalesOrderIDChanging(value);
                this._SalesOrderID = value;
                this.OnSalesOrderIDChanged();
                this.OnPropertyChanged("SalesOrderID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _SalesOrderID;
        partial void OnSalesOrderIDChanging(int value);
        partial void OnSalesOrderIDChanged();
        /// <summary>
        /// There are no comments for Property RevisionNumber in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte RevisionNumber
        {
            get
            {
                return this._RevisionNumber;
            }
            set
            {
                this.OnRevisionNumberChanging(value);
                this._RevisionNumber = value;
                this.OnRevisionNumberChanged();
                this.OnPropertyChanged("RevisionNumber");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte _RevisionNumber;
        partial void OnRevisionNumberChanging(byte value);
        partial void OnRevisionNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this.OnOrderDateChanging(value);
                this._OrderDate = value;
                this.OnOrderDateChanged();
                this.OnPropertyChanged("OrderDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _OrderDate;
        partial void OnOrderDateChanging(global::System.DateTime value);
        partial void OnOrderDateChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _DueDate;
        partial void OnDueDateChanging(global::System.DateTime value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property ShipDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> ShipDate
        {
            get
            {
                return this._ShipDate;
            }
            set
            {
                this.OnShipDateChanging(value);
                this._ShipDate = value;
                this.OnShipDateChanged();
                this.OnPropertyChanged("ShipDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _ShipDate;
        partial void OnShipDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnShipDateChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte _Status;
        partial void OnStatusChanging(byte value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property OnlineOrderFlag in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool OnlineOrderFlag
        {
            get
            {
                return this._OnlineOrderFlag;
            }
            set
            {
                this.OnOnlineOrderFlagChanging(value);
                this._OnlineOrderFlag = value;
                this.OnOnlineOrderFlagChanged();
                this.OnPropertyChanged("OnlineOrderFlag");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _OnlineOrderFlag;
        partial void OnOnlineOrderFlagChanging(bool value);
        partial void OnOnlineOrderFlagChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderNumber in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this.OnSalesOrderNumberChanging(value);
                this._SalesOrderNumber = value;
                this.OnSalesOrderNumberChanged();
                this.OnPropertyChanged("SalesOrderNumber");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(string value);
        partial void OnSalesOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property PurchaseOrderNumber in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PurchaseOrderNumber
        {
            get
            {
                return this._PurchaseOrderNumber;
            }
            set
            {
                this.OnPurchaseOrderNumberChanging(value);
                this._PurchaseOrderNumber = value;
                this.OnPurchaseOrderNumberChanged();
                this.OnPropertyChanged("PurchaseOrderNumber");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PurchaseOrderNumber;
        partial void OnPurchaseOrderNumberChanging(string value);
        partial void OnPurchaseOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property AccountNumber in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this.OnAccountNumberChanging(value);
                this._AccountNumber = value;
                this.OnAccountNumberChanged();
                this.OnPropertyChanged("AccountNumber");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _AccountNumber;
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property CustomerID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this.OnCustomerIDChanging(value);
                this._CustomerID = value;
                this.OnCustomerIDChanged();
                this.OnPropertyChanged("CustomerID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _CustomerID;
        partial void OnCustomerIDChanging(int value);
        partial void OnCustomerIDChanged();
        /// <summary>
        /// There are no comments for Property ShipToAddressID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> ShipToAddressID
        {
            get
            {
                return this._ShipToAddressID;
            }
            set
            {
                this.OnShipToAddressIDChanging(value);
                this._ShipToAddressID = value;
                this.OnShipToAddressIDChanged();
                this.OnPropertyChanged("ShipToAddressID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _ShipToAddressID;
        partial void OnShipToAddressIDChanging(global::System.Nullable<int> value);
        partial void OnShipToAddressIDChanged();
        /// <summary>
        /// There are no comments for Property BillToAddressID in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> BillToAddressID
        {
            get
            {
                return this._BillToAddressID;
            }
            set
            {
                this.OnBillToAddressIDChanging(value);
                this._BillToAddressID = value;
                this.OnBillToAddressIDChanged();
                this.OnPropertyChanged("BillToAddressID");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _BillToAddressID;
        partial void OnBillToAddressIDChanging(global::System.Nullable<int> value);
        partial void OnBillToAddressIDChanged();
        /// <summary>
        /// There are no comments for Property ShipMethod in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ShipMethod
        {
            get
            {
                return this._ShipMethod;
            }
            set
            {
                this.OnShipMethodChanging(value);
                this._ShipMethod = value;
                this.OnShipMethodChanged();
                this.OnPropertyChanged("ShipMethod");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ShipMethod;
        partial void OnShipMethodChanging(string value);
        partial void OnShipMethodChanged();
        /// <summary>
        /// There are no comments for Property CreditCardApprovalCode in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CreditCardApprovalCode
        {
            get
            {
                return this._CreditCardApprovalCode;
            }
            set
            {
                this.OnCreditCardApprovalCodeChanging(value);
                this._CreditCardApprovalCode = value;
                this.OnCreditCardApprovalCodeChanged();
                this.OnPropertyChanged("CreditCardApprovalCode");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CreditCardApprovalCode;
        partial void OnCreditCardApprovalCodeChanging(string value);
        partial void OnCreditCardApprovalCodeChanged();
        /// <summary>
        /// There are no comments for Property SubTotal in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal SubTotal
        {
            get
            {
                return this._SubTotal;
            }
            set
            {
                this.OnSubTotalChanging(value);
                this._SubTotal = value;
                this.OnSubTotalChanged();
                this.OnPropertyChanged("SubTotal");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _SubTotal;
        partial void OnSubTotalChanging(decimal value);
        partial void OnSubTotalChanged();
        /// <summary>
        /// There are no comments for Property TaxAmt in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal TaxAmt
        {
            get
            {
                return this._TaxAmt;
            }
            set
            {
                this.OnTaxAmtChanging(value);
                this._TaxAmt = value;
                this.OnTaxAmtChanged();
                this.OnPropertyChanged("TaxAmt");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _TaxAmt;
        partial void OnTaxAmtChanging(decimal value);
        partial void OnTaxAmtChanged();
        /// <summary>
        /// There are no comments for Property Freight in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this.OnFreightChanging(value);
                this._Freight = value;
                this.OnFreightChanged();
                this.OnPropertyChanged("Freight");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _Freight;
        partial void OnFreightChanging(decimal value);
        partial void OnFreightChanged();
        /// <summary>
        /// There are no comments for Property TotalDue in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal TotalDue
        {
            get
            {
                return this._TotalDue;
            }
            set
            {
                this.OnTotalDueChanging(value);
                this._TotalDue = value;
                this.OnTotalDueChanged();
                this.OnPropertyChanged("TotalDue");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _TotalDue;
        partial void OnTotalDueChanging(decimal value);
        partial void OnTotalDueChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        /// <summary>
        /// There are no comments for Property rowguid in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Guid rowguid
        {
            get
            {
                return this._rowguid;
            }
            set
            {
                this.OnrowguidChanging(value);
                this._rowguid = value;
                this.OnrowguidChanged();
                this.OnPropertyChanged("rowguid");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
        /// <summary>
        /// There are no comments for Property ModifiedDate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this.OnModifiedDateChanging(value);
                this._ModifiedDate = value;
                this.OnModifiedDateChanged();
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
