﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OssAwesomenessTabulator.CodePlex {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProjectTfsInfo", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    [System.SerializableAttribute()]
    public partial class ProjectTfsInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProjectPrefixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TfsServerUrlField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProjectPrefix {
            get {
                return this.ProjectPrefixField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjectPrefixField, value) != true)) {
                    this.ProjectPrefixField = value;
                    this.RaisePropertyChanged("ProjectPrefix");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string TfsServerUrl {
            get {
                return this.TfsServerUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.TfsServerUrlField, value) != true)) {
                    this.TfsServerUrlField = value;
                    this.RaisePropertyChanged("TfsServerUrl");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", ConfigurationName="CodePlex.ProjectInfoServiceSoap")]
    public interface ProjectInfoServiceSoap {
        
        // CODEGEN: Generating message contract since element name ProjectName from namespace http://www.codeplex.com/services/ProjectInfoService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/GetTfsInfoForProject", ReplyAction="*")]
        global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponse GetTfsInfoForProject(global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/GetTfsInfoForProject", ReplyAction="*")]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponse> GetTfsInfoForProjectAsync(global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest request);
        
        // CODEGEN: Generating message contract since element name CodePlexUserName from namespace http://www.codeplex.com/services/ProjectInfoService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/ListProjectsForUser", ReplyAction="*")]
        global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponse ListProjectsForUser(global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/ListProjectsForUser", ReplyAction="*")]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponse> ListProjectsForUserAsync(global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest request);
        
        // CODEGEN: Generating message contract since element name affiliateName from namespace http://www.codeplex.com/services/ProjectInfoService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/ListProjectsForAffiliate" +
            "", ReplyAction="*")]
        global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponse ListProjectsForAffiliate(global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/ListProjectsForAffiliate" +
            "", ReplyAction="*")]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponse> ListProjectsForAffiliateAsync(global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest request);
        
        // CODEGEN: Generating message contract since element name projectName from namespace http://www.codeplex.com/services/ProjectInfoService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/GetProjectByName", ReplyAction="*")]
        global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponse GetProjectByName(global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/GetProjectByName", ReplyAction="*")]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponse> GetProjectByNameAsync(global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest request);
        
        // CODEGEN: Generating message contract since element name UserName from namespace http://www.codeplex.com/services/ProjectInfoService/v1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/CodePlexUserNameToTfsUse" +
            "rName", ReplyAction="*")]
        global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponse CodePlexUserNameToTfsUserName(global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.codeplex.com/services/ProjectInfoService/v1.0/CodePlexUserNameToTfsUse" +
            "rName", ReplyAction="*")]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponse> CodePlexUserNameToTfsUserNameAsync(global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTfsInfoForProjectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTfsInfoForProject", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequestBody Body;
        
        public GetTfsInfoForProjectRequest() {
        }
        
        public GetTfsInfoForProjectRequest(global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class GetTfsInfoForProjectRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ProjectName;
        
        public GetTfsInfoForProjectRequestBody() {
        }
        
        public GetTfsInfoForProjectRequestBody(string ProjectName) {
            this.ProjectName = ProjectName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTfsInfoForProjectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTfsInfoForProjectResponse", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponseBody Body;
        
        public GetTfsInfoForProjectResponse() {
        }
        
        public GetTfsInfoForProjectResponse(global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class GetTfsInfoForProjectResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OssAwesomenessTabulator.CodePlex.ProjectTfsInfo GetTfsInfoForProjectResult;
        
        public GetTfsInfoForProjectResponseBody() {
        }
        
        public GetTfsInfoForProjectResponseBody(OssAwesomenessTabulator.CodePlex.ProjectTfsInfo GetTfsInfoForProjectResult) {
            this.GetTfsInfoForProjectResult = GetTfsInfoForProjectResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListProjectsForUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListProjectsForUser", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequestBody Body;
        
        public ListProjectsForUserRequest() {
        }
        
        public ListProjectsForUserRequest(global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class ListProjectsForUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CodePlexUserName;
        
        public ListProjectsForUserRequestBody() {
        }
        
        public ListProjectsForUserRequestBody(string CodePlexUserName) {
            this.CodePlexUserName = CodePlexUserName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListProjectsForUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListProjectsForUserResponse", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponseBody Body;
        
        public ListProjectsForUserResponse() {
        }
        
        public ListProjectsForUserResponse(global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class ListProjectsForUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public OssAwesomenessTabulator.CodePlex.ArrayOfString ListProjectsForUserResult;
        
        public ListProjectsForUserResponseBody() {
        }
        
        public ListProjectsForUserResponseBody(OssAwesomenessTabulator.CodePlex.ArrayOfString ListProjectsForUserResult) {
            this.ListProjectsForUserResult = ListProjectsForUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListProjectsForAffiliateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListProjectsForAffiliate", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequestBody Body;
        
        public ListProjectsForAffiliateRequest() {
        }
        
        public ListProjectsForAffiliateRequest(global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class ListProjectsForAffiliateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string affiliateName;
        
        public ListProjectsForAffiliateRequestBody() {
        }
        
        public ListProjectsForAffiliateRequestBody(string affiliateName) {
            this.affiliateName = affiliateName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListProjectsForAffiliateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListProjectsForAffiliateResponse", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponseBody Body;
        
        public ListProjectsForAffiliateResponse() {
        }
        
        public ListProjectsForAffiliateResponse(global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class ListProjectsForAffiliateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement ListProjectsForAffiliateResult;
        
        public ListProjectsForAffiliateResponseBody() {
        }
        
        public ListProjectsForAffiliateResponseBody(System.Xml.Linq.XElement ListProjectsForAffiliateResult) {
            this.ListProjectsForAffiliateResult = ListProjectsForAffiliateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProjectByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProjectByName", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequestBody Body;
        
        public GetProjectByNameRequest() {
        }
        
        public GetProjectByNameRequest(global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class GetProjectByNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string projectName;
        
        public GetProjectByNameRequestBody() {
        }
        
        public GetProjectByNameRequestBody(string projectName) {
            this.projectName = projectName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProjectByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProjectByNameResponse", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponseBody Body;
        
        public GetProjectByNameResponse() {
        }
        
        public GetProjectByNameResponse(global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class GetProjectByNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement GetProjectByNameResult;
        
        public GetProjectByNameResponseBody() {
        }
        
        public GetProjectByNameResponseBody(System.Xml.Linq.XElement GetProjectByNameResult) {
            this.GetProjectByNameResult = GetProjectByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CodePlexUserNameToTfsUserNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CodePlexUserNameToTfsUserName", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequestBody Body;
        
        public CodePlexUserNameToTfsUserNameRequest() {
        }
        
        public CodePlexUserNameToTfsUserNameRequest(global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class CodePlexUserNameToTfsUserNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UserName;
        
        public CodePlexUserNameToTfsUserNameRequestBody() {
        }
        
        public CodePlexUserNameToTfsUserNameRequestBody(string UserName) {
            this.UserName = UserName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CodePlexUserNameToTfsUserNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CodePlexUserNameToTfsUserNameResponse", Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0", Order=0)]
        public global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponseBody Body;
        
        public CodePlexUserNameToTfsUserNameResponse() {
        }
        
        public CodePlexUserNameToTfsUserNameResponse(global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.codeplex.com/services/ProjectInfoService/v1.0")]
    public partial class CodePlexUserNameToTfsUserNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CodePlexUserNameToTfsUserNameResult;
        
        public CodePlexUserNameToTfsUserNameResponseBody() {
        }
        
        public CodePlexUserNameToTfsUserNameResponseBody(string CodePlexUserNameToTfsUserNameResult) {
            this.CodePlexUserNameToTfsUserNameResult = CodePlexUserNameToTfsUserNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProjectInfoServiceSoapChannel : global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProjectInfoServiceSoapClient : System.ServiceModel.ClientBase<global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap>, global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap {
        
        public ProjectInfoServiceSoapClient() {
        }
        
        public ProjectInfoServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProjectInfoServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectInfoServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectInfoServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponse global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.GetTfsInfoForProject(global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest request) {
            return base.Channel.GetTfsInfoForProject(request);
        }
        
        public OssAwesomenessTabulator.CodePlex.ProjectTfsInfo GetTfsInfoForProject(string ProjectName) {
            global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest inValue = new global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequestBody();
            inValue.Body.ProjectName = ProjectName;
            global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponse retVal = ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).GetTfsInfoForProject(inValue);
            return retVal.Body.GetTfsInfoForProjectResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponse> global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.GetTfsInfoForProjectAsync(global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest request) {
            return base.Channel.GetTfsInfoForProjectAsync(request);
        }
        
        public System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectResponse> GetTfsInfoForProjectAsync(string ProjectName) {
            global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest inValue = new global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.GetTfsInfoForProjectRequestBody();
            inValue.Body.ProjectName = ProjectName;
            return ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).GetTfsInfoForProjectAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponse global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.ListProjectsForUser(global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest request) {
            return base.Channel.ListProjectsForUser(request);
        }
        
        public OssAwesomenessTabulator.CodePlex.ArrayOfString ListProjectsForUser(string CodePlexUserName) {
            global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest inValue = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequestBody();
            inValue.Body.CodePlexUserName = CodePlexUserName;
            global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponse retVal = ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).ListProjectsForUser(inValue);
            return retVal.Body.ListProjectsForUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponse> global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.ListProjectsForUserAsync(global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest request) {
            return base.Channel.ListProjectsForUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserResponse> ListProjectsForUserAsync(string CodePlexUserName) {
            global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest inValue = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForUserRequestBody();
            inValue.Body.CodePlexUserName = CodePlexUserName;
            return ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).ListProjectsForUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponse global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.ListProjectsForAffiliate(global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest request) {
            return base.Channel.ListProjectsForAffiliate(request);
        }
        
        public System.Xml.Linq.XElement ListProjectsForAffiliate(string affiliateName) {
            global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest inValue = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequestBody();
            inValue.Body.affiliateName = affiliateName;
            global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponse retVal = ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).ListProjectsForAffiliate(inValue);
            return retVal.Body.ListProjectsForAffiliateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponse> global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.ListProjectsForAffiliateAsync(global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest request) {
            return base.Channel.ListProjectsForAffiliateAsync(request);
        }
        
        public System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateResponse> ListProjectsForAffiliateAsync(string affiliateName) {
            global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest inValue = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.ListProjectsForAffiliateRequestBody();
            inValue.Body.affiliateName = affiliateName;
            return ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).ListProjectsForAffiliateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponse global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.GetProjectByName(global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest request) {
            return base.Channel.GetProjectByName(request);
        }
        
        public System.Xml.Linq.XElement GetProjectByName(string projectName) {
            global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest inValue = new global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequestBody();
            inValue.Body.projectName = projectName;
            global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponse retVal = ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).GetProjectByName(inValue);
            return retVal.Body.GetProjectByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponse> global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.GetProjectByNameAsync(global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest request) {
            return base.Channel.GetProjectByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.GetProjectByNameResponse> GetProjectByNameAsync(string projectName) {
            global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest inValue = new global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.GetProjectByNameRequestBody();
            inValue.Body.projectName = projectName;
            return ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).GetProjectByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponse global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.CodePlexUserNameToTfsUserName(global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest request) {
            return base.Channel.CodePlexUserNameToTfsUserName(request);
        }
        
        public string CodePlexUserNameToTfsUserName(string UserName) {
            global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest inValue = new global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequestBody();
            inValue.Body.UserName = UserName;
            global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponse retVal = ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).CodePlexUserNameToTfsUserName(inValue);
            return retVal.Body.CodePlexUserNameToTfsUserNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponse> global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap.CodePlexUserNameToTfsUserNameAsync(global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest request) {
            return base.Channel.CodePlexUserNameToTfsUserNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameResponse> CodePlexUserNameToTfsUserNameAsync(string UserName) {
            global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest inValue = new global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequest();
            inValue.Body = new global::OssAwesomenessTabulator.CodePlex.CodePlexUserNameToTfsUserNameRequestBody();
            inValue.Body.UserName = UserName;
            return ((global::OssAwesomenessTabulator.CodePlex.ProjectInfoServiceSoap)(this)).CodePlexUserNameToTfsUserNameAsync(inValue);
        }
    }
}
