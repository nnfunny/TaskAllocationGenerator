﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskAllocationGenerator.LocalGreedyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocalGreedyService.IGreedyService")]
    public interface IGreedyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGreedyService/FindAllocations", ReplyAction="http://tempuri.org/IGreedyService/FindAllocationsResponse")]
        string FindAllocations(TaskAllocationUtils.Files.ConfigurationFile configurationFile);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IGreedyService/FindAllocations", ReplyAction="http://tempuri.org/IGreedyService/FindAllocationsResponse")]
        System.IAsyncResult BeginFindAllocations(TaskAllocationUtils.Files.ConfigurationFile configurationFile, System.AsyncCallback callback, object asyncState);
        
        string EndFindAllocations(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGreedyServiceChannel : TaskAllocationGenerator.LocalGreedyService.IGreedyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FindAllocationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public FindAllocationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GreedyServiceClient : System.ServiceModel.ClientBase<TaskAllocationGenerator.LocalGreedyService.IGreedyService>, TaskAllocationGenerator.LocalGreedyService.IGreedyService {
        
        private BeginOperationDelegate onBeginFindAllocationsDelegate;
        
        private EndOperationDelegate onEndFindAllocationsDelegate;
        
        private System.Threading.SendOrPostCallback onFindAllocationsCompletedDelegate;
        
        public GreedyServiceClient() {
        }
        
        public GreedyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GreedyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GreedyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GreedyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<FindAllocationsCompletedEventArgs> FindAllocationsCompleted;
        
        public string FindAllocations(TaskAllocationUtils.Files.ConfigurationFile configurationFile) {
            return base.Channel.FindAllocations(configurationFile);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginFindAllocations(TaskAllocationUtils.Files.ConfigurationFile configurationFile, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginFindAllocations(configurationFile, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndFindAllocations(System.IAsyncResult result) {
            return base.Channel.EndFindAllocations(result);
        }
        
        private System.IAsyncResult OnBeginFindAllocations(object[] inValues, System.AsyncCallback callback, object asyncState) {
            TaskAllocationUtils.Files.ConfigurationFile configurationFile = ((TaskAllocationUtils.Files.ConfigurationFile)(inValues[0]));
            return this.BeginFindAllocations(configurationFile, callback, asyncState);
        }
        
        private object[] OnEndFindAllocations(System.IAsyncResult result) {
            string retVal = this.EndFindAllocations(result);
            return new object[] {
                    retVal};
        }
        
        private void OnFindAllocationsCompleted(object state) {
            if ((this.FindAllocationsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.FindAllocationsCompleted(this, new FindAllocationsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void FindAllocationsAsync(TaskAllocationUtils.Files.ConfigurationFile configurationFile) {
            this.FindAllocationsAsync(configurationFile, null);
        }
        
        public void FindAllocationsAsync(TaskAllocationUtils.Files.ConfigurationFile configurationFile, object userState) {
            if ((this.onBeginFindAllocationsDelegate == null)) {
                this.onBeginFindAllocationsDelegate = new BeginOperationDelegate(this.OnBeginFindAllocations);
            }
            if ((this.onEndFindAllocationsDelegate == null)) {
                this.onEndFindAllocationsDelegate = new EndOperationDelegate(this.OnEndFindAllocations);
            }
            if ((this.onFindAllocationsCompletedDelegate == null)) {
                this.onFindAllocationsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFindAllocationsCompleted);
            }
            base.InvokeAsync(this.onBeginFindAllocationsDelegate, new object[] {
                        configurationFile}, this.onEndFindAllocationsDelegate, this.onFindAllocationsCompletedDelegate, userState);
        }
    }
}