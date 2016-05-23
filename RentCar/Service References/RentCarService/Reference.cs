﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCar.RentCarService
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/RentCar.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConfirmPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserLoginField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ConfirmPassword {
            get {
                return this.ConfirmPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfirmPasswordField, value) != true)) {
                    this.ConfirmPasswordField = value;
                    this.RaisePropertyChanged("ConfirmPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserLogin {
            get {
                return this.UserLoginField;
            }
            set {
                if ((object.ReferenceEquals(this.UserLoginField, value) != true)) {
                    this.UserLoginField = value;
                    this.RaisePropertyChanged("UserLogin");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RentCarService.IRentCarService")]
    public interface IRentCarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/CheckLogin", ReplyAction="http://tempuri.org/IRentCarService/CheckLoginResponse")]
        bool CheckLogin(RentCar.RentCarService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/CheckLogin", ReplyAction="http://tempuri.org/IRentCarService/CheckLoginResponse")]
        System.Threading.Tasks.Task<bool> CheckLoginAsync(RentCar.RentCarService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/CheckLoggedIn", ReplyAction="http://tempuri.org/IRentCarService/CheckLoggedInResponse")]
        bool CheckLoggedIn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/CheckLoggedIn", ReplyAction="http://tempuri.org/IRentCarService/CheckLoggedInResponse")]
        System.Threading.Tasks.Task<bool> CheckLoggedInAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/CheckRegister", ReplyAction="http://tempuri.org/IRentCarService/CheckRegisterResponse")]
        bool CheckRegister(RentCar.RentCarService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/CheckRegister", ReplyAction="http://tempuri.org/IRentCarService/CheckRegisterResponse")]
        System.Threading.Tasks.Task<bool> CheckRegisterAsync(RentCar.RentCarService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/Register", ReplyAction="http://tempuri.org/IRentCarService/RegisterResponse")]
        void Register(RentCar.RentCarService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentCarService/Register", ReplyAction="http://tempuri.org/IRentCarService/RegisterResponse")]
        System.Threading.Tasks.Task RegisterAsync(RentCar.RentCarService.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRentCarServiceChannel : RentCar.RentCarService.IRentCarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RentCarServiceClient : System.ServiceModel.ClientBase<RentCar.RentCarService.IRentCarService>, RentCar.RentCarService.IRentCarService {
        
        public RentCarServiceClient() {
        }
        
        public RentCarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RentCarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RentCarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RentCarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckLogin(RentCar.RentCarService.User user) {
            return base.Channel.CheckLogin(user);
        }
        
        public System.Threading.Tasks.Task<bool> CheckLoginAsync(RentCar.RentCarService.User user) {
            return base.Channel.CheckLoginAsync(user);
        }
        
        public bool CheckLoggedIn() {
            return base.Channel.CheckLoggedIn();
        }
        
        public System.Threading.Tasks.Task<bool> CheckLoggedInAsync() {
            return base.Channel.CheckLoggedInAsync();
        }
        
        public bool CheckRegister(RentCar.RentCarService.User user) {
            return base.Channel.CheckRegister(user);
        }
        
        public System.Threading.Tasks.Task<bool> CheckRegisterAsync(RentCar.RentCarService.User user) {
            return base.Channel.CheckRegisterAsync(user);
        }
        
        public void Register(RentCar.RentCarService.User user) {
            base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task RegisterAsync(RentCar.RentCarService.User user) {
            return base.Channel.RegisterAsync(user);
        }
    }
}
