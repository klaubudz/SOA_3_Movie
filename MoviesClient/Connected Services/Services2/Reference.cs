﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesClient.Services2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Review", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Review : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MoviesClient.Services2.Person AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MovieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ScoreField;
        
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
        public MoviesClient.Services2.Person Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Movie {
            get {
                return this.MovieField;
            }
            set {
                if ((this.MovieField.Equals(value) != true)) {
                    this.MovieField = value;
                    this.RaisePropertyChanged("Movie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Score {
            get {
                return this.ScoreField;
            }
            set {
                if ((this.ScoreField.Equals(value) != true)) {
                    this.ScoreField = value;
                    this.RaisePropertyChanged("Score");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Services2.IReviewPersonService")]
    public interface IReviewPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/CreateReview", ReplyAction="http://tempuri.org/IReviewPersonService/CreateReviewResponse")]
        int CreateReview(MoviesClient.Services2.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/GetReview", ReplyAction="http://tempuri.org/IReviewPersonService/GetReviewResponse")]
        MoviesClient.Services2.Review GetReview(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/GetAllReviews", ReplyAction="http://tempuri.org/IReviewPersonService/GetAllReviewsResponse")]
        System.Collections.Generic.List<MoviesClient.Services2.Review> GetAllReviews();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/UpdateReview", ReplyAction="http://tempuri.org/IReviewPersonService/UpdateReviewResponse")]
        void UpdateReview(MoviesClient.Services2.Review review);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/DeleteReview", ReplyAction="http://tempuri.org/IReviewPersonService/DeleteReviewResponse")]
        void DeleteReview(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/CreatePerson", ReplyAction="http://tempuri.org/IReviewPersonService/CreatePersonResponse")]
        int CreatePerson(MoviesClient.Services2.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/GetPerson", ReplyAction="http://tempuri.org/IReviewPersonService/GetPersonResponse")]
        MoviesClient.Services2.Person GetPerson(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/GetAllPersons", ReplyAction="http://tempuri.org/IReviewPersonService/GetAllPersonsResponse")]
        System.Collections.Generic.List<MoviesClient.Services2.Person> GetAllPersons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/UpdatePerson", ReplyAction="http://tempuri.org/IReviewPersonService/UpdatePersonResponse")]
        void UpdatePerson(MoviesClient.Services2.Person person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewPersonService/DeletePerson", ReplyAction="http://tempuri.org/IReviewPersonService/DeletePersonResponse")]
        void DeletePerson(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReviewPersonServiceChannel : MoviesClient.Services2.IReviewPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReviewPersonServiceClient : System.ServiceModel.ClientBase<MoviesClient.Services2.IReviewPersonService>, MoviesClient.Services2.IReviewPersonService {
        
        public ReviewPersonServiceClient() {
        }
        
        public ReviewPersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReviewPersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewPersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewPersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CreateReview(MoviesClient.Services2.Review review) {
            return base.Channel.CreateReview(review);
        }
        
        public MoviesClient.Services2.Review GetReview(int id) {
            return base.Channel.GetReview(id);
        }
        
        public System.Collections.Generic.List<MoviesClient.Services2.Review> GetAllReviews() {
            return base.Channel.GetAllReviews();
        }
        
        public void UpdateReview(MoviesClient.Services2.Review review) {
            base.Channel.UpdateReview(review);
        }
        
        public void DeleteReview(int id) {
            base.Channel.DeleteReview(id);
        }
        
        public int CreatePerson(MoviesClient.Services2.Person person) {
            return base.Channel.CreatePerson(person);
        }
        
        public MoviesClient.Services2.Person GetPerson(int id) {
            return base.Channel.GetPerson(id);
        }
        
        public System.Collections.Generic.List<MoviesClient.Services2.Person> GetAllPersons() {
            return base.Channel.GetAllPersons();
        }
        
        public void UpdatePerson(MoviesClient.Services2.Person person) {
            base.Channel.UpdatePerson(person);
        }
        
        public void DeletePerson(int id) {
            base.Channel.DeletePerson(id);
        }
    }
}
