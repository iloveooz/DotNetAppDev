﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30128.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HolidayRequestActivityLibrary.CalcIDService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcIDService.ICalculateReferenceIDService")]
    public interface ICalculateReferenceIDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculateReferenceIDService/GetNewReferenceID", ReplyAction="http://tempuri.org/ICalculateReferenceIDService/GetNewReferenceIDResponse")]
        HolidayRequestActivityLibrary.CalcIDService.GetNewReferenceIDResponse GetNewReferenceID(HolidayRequestActivityLibrary.CalcIDService.GetNewReferenceIDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNewReferenceID", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetNewReferenceIDRequest {
        
        public GetNewReferenceIDRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetNewReferenceIDResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetNewReferenceIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int GetNewReferenceIDResult;
        
        public GetNewReferenceIDResponse() {
        }
        
        public GetNewReferenceIDResponse(int GetNewReferenceIDResult) {
            this.GetNewReferenceIDResult = GetNewReferenceIDResult;
        }
    }
}
