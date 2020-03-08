﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebEncuesta.LoginWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback loginOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_usr_activosOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_usr_faltasOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_usr_retardosOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_usr_salidasOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_usr_basicoOperationCompleted;
        
        private System.Threading.SendOrPostCallback get_usr_empleadosOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::WebEncuesta.Properties.Settings.Default.WebEncuesta_LoginWS_Service1;
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
        public event loginCompletedEventHandler loginCompleted;
        
        /// <remarks/>
        public event get_usr_activosCompletedEventHandler get_usr_activosCompleted;
        
        /// <remarks/>
        public event get_usr_faltasCompletedEventHandler get_usr_faltasCompleted;
        
        /// <remarks/>
        public event get_usr_retardosCompletedEventHandler get_usr_retardosCompleted;
        
        /// <remarks/>
        public event get_usr_salidasCompletedEventHandler get_usr_salidasCompleted;
        
        /// <remarks/>
        public event get_usr_basicoCompletedEventHandler get_usr_basicoCompleted;
        
        /// <remarks/>
        public event get_usr_empleadosCompletedEventHandler get_usr_empleadosCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/login", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string login(string usuario, string password) {
            object[] results = this.Invoke("login", new object[] {
                        usuario,
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void loginAsync(string usuario, string password) {
            this.loginAsync(usuario, password, null);
        }
        
        /// <remarks/>
        public void loginAsync(string usuario, string password, object userState) {
            if ((this.loginOperationCompleted == null)) {
                this.loginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloginOperationCompleted);
            }
            this.InvokeAsync("login", new object[] {
                        usuario,
                        password}, this.loginOperationCompleted, userState);
        }
        
        private void OnloginOperationCompleted(object arg) {
            if ((this.loginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loginCompleted(this, new loginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/get_usr_activos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet get_usr_activos(string f1, string f2) {
            object[] results = this.Invoke("get_usr_activos", new object[] {
                        f1,
                        f2});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void get_usr_activosAsync(string f1, string f2) {
            this.get_usr_activosAsync(f1, f2, null);
        }
        
        /// <remarks/>
        public void get_usr_activosAsync(string f1, string f2, object userState) {
            if ((this.get_usr_activosOperationCompleted == null)) {
                this.get_usr_activosOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_usr_activosOperationCompleted);
            }
            this.InvokeAsync("get_usr_activos", new object[] {
                        f1,
                        f2}, this.get_usr_activosOperationCompleted, userState);
        }
        
        private void Onget_usr_activosOperationCompleted(object arg) {
            if ((this.get_usr_activosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_usr_activosCompleted(this, new get_usr_activosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/get_usr_faltas", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet get_usr_faltas(int id, string f1, string f2) {
            object[] results = this.Invoke("get_usr_faltas", new object[] {
                        id,
                        f1,
                        f2});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void get_usr_faltasAsync(int id, string f1, string f2) {
            this.get_usr_faltasAsync(id, f1, f2, null);
        }
        
        /// <remarks/>
        public void get_usr_faltasAsync(int id, string f1, string f2, object userState) {
            if ((this.get_usr_faltasOperationCompleted == null)) {
                this.get_usr_faltasOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_usr_faltasOperationCompleted);
            }
            this.InvokeAsync("get_usr_faltas", new object[] {
                        id,
                        f1,
                        f2}, this.get_usr_faltasOperationCompleted, userState);
        }
        
        private void Onget_usr_faltasOperationCompleted(object arg) {
            if ((this.get_usr_faltasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_usr_faltasCompleted(this, new get_usr_faltasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/get_usr_retardos", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet get_usr_retardos(int id, string f1, string f2) {
            object[] results = this.Invoke("get_usr_retardos", new object[] {
                        id,
                        f1,
                        f2});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void get_usr_retardosAsync(int id, string f1, string f2) {
            this.get_usr_retardosAsync(id, f1, f2, null);
        }
        
        /// <remarks/>
        public void get_usr_retardosAsync(int id, string f1, string f2, object userState) {
            if ((this.get_usr_retardosOperationCompleted == null)) {
                this.get_usr_retardosOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_usr_retardosOperationCompleted);
            }
            this.InvokeAsync("get_usr_retardos", new object[] {
                        id,
                        f1,
                        f2}, this.get_usr_retardosOperationCompleted, userState);
        }
        
        private void Onget_usr_retardosOperationCompleted(object arg) {
            if ((this.get_usr_retardosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_usr_retardosCompleted(this, new get_usr_retardosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/get_usr_salidas", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet get_usr_salidas(int id, string f1, string f2) {
            object[] results = this.Invoke("get_usr_salidas", new object[] {
                        id,
                        f1,
                        f2});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void get_usr_salidasAsync(int id, string f1, string f2) {
            this.get_usr_salidasAsync(id, f1, f2, null);
        }
        
        /// <remarks/>
        public void get_usr_salidasAsync(int id, string f1, string f2, object userState) {
            if ((this.get_usr_salidasOperationCompleted == null)) {
                this.get_usr_salidasOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_usr_salidasOperationCompleted);
            }
            this.InvokeAsync("get_usr_salidas", new object[] {
                        id,
                        f1,
                        f2}, this.get_usr_salidasOperationCompleted, userState);
        }
        
        private void Onget_usr_salidasOperationCompleted(object arg) {
            if ((this.get_usr_salidasCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_usr_salidasCompleted(this, new get_usr_salidasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/get_usr_basico", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet get_usr_basico(int id) {
            object[] results = this.Invoke("get_usr_basico", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void get_usr_basicoAsync(int id) {
            this.get_usr_basicoAsync(id, null);
        }
        
        /// <remarks/>
        public void get_usr_basicoAsync(int id, object userState) {
            if ((this.get_usr_basicoOperationCompleted == null)) {
                this.get_usr_basicoOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_usr_basicoOperationCompleted);
            }
            this.InvokeAsync("get_usr_basico", new object[] {
                        id}, this.get_usr_basicoOperationCompleted, userState);
        }
        
        private void Onget_usr_basicoOperationCompleted(object arg) {
            if ((this.get_usr_basicoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_usr_basicoCompleted(this, new get_usr_basicoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/get_usr_empleados", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet get_usr_empleados() {
            object[] results = this.Invoke("get_usr_empleados", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void get_usr_empleadosAsync() {
            this.get_usr_empleadosAsync(null);
        }
        
        /// <remarks/>
        public void get_usr_empleadosAsync(object userState) {
            if ((this.get_usr_empleadosOperationCompleted == null)) {
                this.get_usr_empleadosOperationCompleted = new System.Threading.SendOrPostCallback(this.Onget_usr_empleadosOperationCompleted);
            }
            this.InvokeAsync("get_usr_empleados", new object[0], this.get_usr_empleadosOperationCompleted, userState);
        }
        
        private void Onget_usr_empleadosOperationCompleted(object arg) {
            if ((this.get_usr_empleadosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.get_usr_empleadosCompleted(this, new get_usr_empleadosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void loginCompletedEventHandler(object sender, loginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal loginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void get_usr_activosCompletedEventHandler(object sender, get_usr_activosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_usr_activosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_usr_activosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void get_usr_faltasCompletedEventHandler(object sender, get_usr_faltasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_usr_faltasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_usr_faltasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void get_usr_retardosCompletedEventHandler(object sender, get_usr_retardosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_usr_retardosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_usr_retardosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void get_usr_salidasCompletedEventHandler(object sender, get_usr_salidasCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_usr_salidasCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_usr_salidasCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void get_usr_basicoCompletedEventHandler(object sender, get_usr_basicoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_usr_basicoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_usr_basicoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void get_usr_empleadosCompletedEventHandler(object sender, get_usr_empleadosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class get_usr_empleadosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal get_usr_empleadosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591