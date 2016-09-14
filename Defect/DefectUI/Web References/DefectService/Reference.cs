﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1433.
// 
#pragma warning disable 1591

namespace DefectUI.DefectService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://defects.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddDefectOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDefectsOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetDefectStateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::DefectUI.Properties.Settings.Default.DefectUI_DefectService_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddDefectCompletedEventHandler AddDefectCompleted;
        
        /// <remarks/>
        public event GetDefectsCompletedEventHandler GetDefectsCompleted;
        
        /// <remarks/>
        public event SetDefectStateCompletedEventHandler SetDefectStateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://defects.org/AddDefect", RequestNamespace="http://defects.org/", ResponseNamespace="http://defects.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Defect AddDefect(Defect item) {
            object[] results = this.Invoke("AddDefect", new object[] {
                        item});
            return ((Defect)(results[0]));
        }
        
        /// <remarks/>
        public void AddDefectAsync(Defect item) {
            this.AddDefectAsync(item, null);
        }
        
        /// <remarks/>
        public void AddDefectAsync(Defect item, object userState) {
            if ((this.AddDefectOperationCompleted == null)) {
                this.AddDefectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddDefectOperationCompleted);
            }
            this.InvokeAsync("AddDefect", new object[] {
                        item}, this.AddDefectOperationCompleted, userState);
        }
        
        private void OnAddDefectOperationCompleted(object arg) {
            if ((this.AddDefectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddDefectCompleted(this, new AddDefectCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://defects.org/GetDefects", RequestNamespace="http://defects.org/", ResponseNamespace="http://defects.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Defect[] GetDefects() {
            object[] results = this.Invoke("GetDefects", new object[0]);
            return ((Defect[])(results[0]));
        }
        
        /// <remarks/>
        public void GetDefectsAsync() {
            this.GetDefectsAsync(null);
        }
        
        /// <remarks/>
        public void GetDefectsAsync(object userState) {
            if ((this.GetDefectsOperationCompleted == null)) {
                this.GetDefectsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDefectsOperationCompleted);
            }
            this.InvokeAsync("GetDefects", new object[0], this.GetDefectsOperationCompleted, userState);
        }
        
        private void OnGetDefectsOperationCompleted(object arg) {
            if ((this.GetDefectsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDefectsCompleted(this, new GetDefectsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://defects.org/SetDefectState", RequestNamespace="http://defects.org/", ResponseNamespace="http://defects.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Defect SetDefectState(Defect item, DefectState newState) {
            object[] results = this.Invoke("SetDefectState", new object[] {
                        item,
                        newState});
            return ((Defect)(results[0]));
        }
        
        /// <remarks/>
        public void SetDefectStateAsync(Defect item, DefectState newState) {
            this.SetDefectStateAsync(item, newState, null);
        }
        
        /// <remarks/>
        public void SetDefectStateAsync(Defect item, DefectState newState, object userState) {
            if ((this.SetDefectStateOperationCompleted == null)) {
                this.SetDefectStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetDefectStateOperationCompleted);
            }
            this.InvokeAsync("SetDefectState", new object[] {
                        item,
                        newState}, this.SetDefectStateOperationCompleted, userState);
        }
        
        private void OnSetDefectStateOperationCompleted(object arg) {
            if ((this.SetDefectStateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetDefectStateCompleted(this, new SetDefectStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://defects.org/")]
    public partial class Defect {
        
        private int idField;
        
        private string titleField;
        
        private string descriptionField;
        
        private string createdByField;
        
        private DefectState stateField;
        
        private System.DateTime createdDateField;
        
        private string assignedToField;
        
        private System.DateTime assignedDateField;
        
        private System.DateTime closedDateField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string CreatedBy {
            get {
                return this.createdByField;
            }
            set {
                this.createdByField = value;
            }
        }
        
        /// <remarks/>
        public DefectState State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreatedDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }
        
        /// <remarks/>
        public string AssignedTo {
            get {
                return this.assignedToField;
            }
            set {
                this.assignedToField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime AssignedDate {
            get {
                return this.assignedDateField;
            }
            set {
                this.assignedDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ClosedDate {
            get {
                return this.closedDateField;
            }
            set {
                this.closedDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.1433")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://defects.org/")]
    public enum DefectState {
        
        /// <remarks/>
        Opened,
        
        /// <remarks/>
        UnderDevelopement,
        
        /// <remarks/>
        Resolved,
        
        /// <remarks/>
        Rejected,
        
        /// <remarks/>
        Closed,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void AddDefectCompletedEventHandler(object sender, AddDefectCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddDefectCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddDefectCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Defect Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Defect)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void GetDefectsCompletedEventHandler(object sender, GetDefectsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDefectsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDefectsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Defect[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Defect[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    public delegate void SetDefectStateCompletedEventHandler(object sender, SetDefectStateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1433")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SetDefectStateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SetDefectStateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Defect Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Defect)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591