﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Newtouch.CIS.Proxy.ServiceReferenceSqsq {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.wmsps.jalone.com/", ConfigurationName="ServiceReferenceSqsq.IWebService")]
    public interface IWebService {
        
        // CODEGEN: 命名空间  的元素名称 param 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponse service(Newtouch.CIS.Proxy.ServiceReferenceSqsq.service request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponse> serviceAsync(Newtouch.CIS.Proxy.ServiceReferenceSqsq.service request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class service {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="service", Namespace="http://service.wmsps.jalone.com/", Order=0)]
        public Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceBody Body;
        
        public service() {
        }
        
        public service(Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class serviceBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string param;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public serviceBody() {
        }
        
        public serviceBody(string param, string data) {
            this.param = param;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class serviceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="serviceResponse", Namespace="http://service.wmsps.jalone.com/", Order=0)]
        public Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponseBody Body;
        
        public serviceResponse() {
        }
        
        public serviceResponse(Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class serviceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string String;
        
        public serviceResponseBody() {
        }
        
        public serviceResponseBody(string String) {
            this.String = String;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServiceChannel : Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceClient : System.ServiceModel.ClientBase<Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService>, Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService {
        
        public WebServiceClient() {
        }
        
        public WebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponse Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService.service(Newtouch.CIS.Proxy.ServiceReferenceSqsq.service request) {
            return base.Channel.service(request);
        }
        
        public string service(string param, string data) {
            Newtouch.CIS.Proxy.ServiceReferenceSqsq.service inValue = new Newtouch.CIS.Proxy.ServiceReferenceSqsq.service();
            inValue.Body = new Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceBody();
            inValue.Body.param = param;
            inValue.Body.data = data;
            Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponse retVal = ((Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService)(this)).service(inValue);
            return retVal.Body.String;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponse> Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService.serviceAsync(Newtouch.CIS.Proxy.ServiceReferenceSqsq.service request) {
            return base.Channel.serviceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceResponse> serviceAsync(string param, string data) {
            Newtouch.CIS.Proxy.ServiceReferenceSqsq.service inValue = new Newtouch.CIS.Proxy.ServiceReferenceSqsq.service();
            inValue.Body = new Newtouch.CIS.Proxy.ServiceReferenceSqsq.serviceBody();
            inValue.Body.param = param;
            inValue.Body.data = data;
            return ((Newtouch.CIS.Proxy.ServiceReferenceSqsq.IWebService)(this)).serviceAsync(inValue);
        }
    }
}