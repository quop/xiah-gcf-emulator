﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GCFLauncher.LauncherServiceNS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/LoginService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LauncherServiceNS.ILauncherService")]
    public interface ILauncherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILauncherService/GetData", ReplyAction="http://tempuri.org/ILauncherService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILauncherService/TryLogin", ReplyAction="http://tempuri.org/ILauncherService/TryLoginResponse")]
        bool TryLogin(out string hashCode, string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILauncherService/IsServerOn", ReplyAction="http://tempuri.org/ILauncherService/IsServerOnResponse")]
        bool IsServerOn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILauncherService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ILauncherService/GetDataUsingDataContractResponse")]
        GCFLauncher.LauncherServiceNS.CompositeType GetDataUsingDataContract(GCFLauncher.LauncherServiceNS.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILauncherServiceChannel : GCFLauncher.LauncherServiceNS.ILauncherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LauncherServiceClient : System.ServiceModel.ClientBase<GCFLauncher.LauncherServiceNS.ILauncherService>, GCFLauncher.LauncherServiceNS.ILauncherService {
        
        public LauncherServiceClient() {
        }
        
        public LauncherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LauncherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LauncherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LauncherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public bool TryLogin(out string hashCode, string username, string password) {
            return base.Channel.TryLogin(out hashCode, username, password);
        }
        
        public bool IsServerOn() {
            return base.Channel.IsServerOn();
        }
        
        public GCFLauncher.LauncherServiceNS.CompositeType GetDataUsingDataContract(GCFLauncher.LauncherServiceNS.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
    }
}
