﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Newtouch.CIS.Proxy.TcmHis01ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://components.ecm.core.engine.transfer.com", ConfigurationName="TcmHis01ServiceReference._Proxy70")]
    public interface _Proxy70 {
        
        // CODEGEN: 消息 acceptMessageRequest 的包装命名空间(http://proxy.sun.com)以后生成的消息协定与默认值(http://components.ecm.core.engine.transfer.com)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageResponse acceptMessage(Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageResponse> acceptMessageAsync(Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="acceptMessage", WrapperNamespace="http://proxy.sun.com", IsWrapped=true)]
    public partial class acceptMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string in0;
        
        public acceptMessageRequest() {
        }
        
        public acceptMessageRequest(string in0) {
            this.in0 = in0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="acceptMessageResponse", WrapperNamespace="http://components.ecm.core.engine.transfer.com", IsWrapped=true)]
    public partial class acceptMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string acceptMessageReturn;
        
        public acceptMessageResponse() {
        }
        
        public acceptMessageResponse(string acceptMessageReturn) {
            this.acceptMessageReturn = acceptMessageReturn;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface _Proxy70Channel : Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class _Proxy70Client : System.ServiceModel.ClientBase<Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70>, Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70 {
        
        public _Proxy70Client() {
        }
        
        public _Proxy70Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public _Proxy70Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public _Proxy70Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public _Proxy70Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageResponse Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70.acceptMessage(Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest request) {
            return base.Channel.acceptMessage(request);
        }
        
        public string acceptMessage(string in0) {
            Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest inValue = new Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest();
            inValue.in0 = in0;
            Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageResponse retVal = ((Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70)(this)).acceptMessage(inValue);
            return retVal.acceptMessageReturn;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageResponse> Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70.acceptMessageAsync(Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest request) {
            return base.Channel.acceptMessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageResponse> acceptMessageAsync(string in0) {
            Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest inValue = new Newtouch.CIS.Proxy.TcmHis01ServiceReference.acceptMessageRequest();
            inValue.in0 = in0;
            return ((Newtouch.CIS.Proxy.TcmHis01ServiceReference._Proxy70)(this)).acceptMessageAsync(inValue);
        }
    }
}