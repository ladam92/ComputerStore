﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerStore.Client.BusinessLogic {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusinessLogic.ILogic")]
    public interface ILogic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/ProcFoglalat_GetKategoriak", ReplyAction="http://tempuri.org/ILogic/ProcFoglalat_GetKategoriakResponse")]
        ComputerStore.DTO.Types.ProcesszorFoglalatTipus[] ProcFoglalat_GetKategoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/ProcFoglalat_GetKategoriak", ReplyAction="http://tempuri.org/ILogic/ProcFoglalat_GetKategoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.ProcesszorFoglalatTipus[]> ProcFoglalat_GetKategoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/MemoriaFoglalat_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/MemoriaFoglalat_GetKaegoriakResponse")]
        ComputerStore.DTO.Types.MemoriaTipus[] MemoriaFoglalat_GetKaegoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/MemoriaFoglalat_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/MemoriaFoglalat_GetKaegoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.MemoriaTipus[]> MemoriaFoglalat_GetKaegoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/UsbTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/UsbTipus_GetKaegoriakResponse")]
        ComputerStore.DTO.Types.UsbTipus[] UsbTipus_GetKaegoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/UsbTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/UsbTipus_GetKaegoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.UsbTipus[]> UsbTipus_GetKaegoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/HattertatTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/HattertatTipus_GetKaegoriakResponse")]
        ComputerStore.DTO.Types.HattertarTipus[] HattertatTipus_GetKaegoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/HattertatTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/HattertatTipus_GetKaegoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.HattertarTipus[]> HattertatTipus_GetKaegoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/HattertatCsatoloTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/HattertatCsatoloTipus_GetKaegoriakResponse")]
        ComputerStore.DTO.Types.HattertarCsatoloTipus[] HattertatCsatoloTipus_GetKaegoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/HattertatCsatoloTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/HattertatCsatoloTipus_GetKaegoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.HattertarCsatoloTipus[]> HattertatCsatoloTipus_GetKaegoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/MonitorFelbontasTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/MonitorFelbontasTipus_GetKaegoriakResponse")]
        ComputerStore.DTO.Types.MonitorFelbontas[] MonitorFelbontasTipus_GetKaegoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/MonitorFelbontasTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/MonitorFelbontasTipus_GetKaegoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.MonitorFelbontas[]> MonitorFelbontasTipus_GetKaegoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/MonitorMeretTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/MonitorMeretTipus_GetKaegoriakResponse")]
        ComputerStore.DTO.Types.MonitorMeret[] MonitorMeretTipus_GetKaegoriak();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/MonitorMeretTipus_GetKaegoriak", ReplyAction="http://tempuri.org/ILogic/MonitorMeretTipus_GetKaegoriakResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.MonitorMeret[]> MonitorMeretTipus_GetKaegoriakAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Alaplap_GetByFoglalatID", ReplyAction="http://tempuri.org/ILogic/Alaplap_GetByFoglalatIDResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap> Alaplap_GetByFoglalatID(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Alaplap_GetByFoglalatID", ReplyAction="http://tempuri.org/ILogic/Alaplap_GetByFoglalatIDResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap>> Alaplap_GetByFoglalatIDAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Alaplap_GetByMemoriaID", ReplyAction="http://tempuri.org/ILogic/Alaplap_GetByMemoriaIDResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap> Alaplap_GetByMemoriaID(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Alaplap_GetByMemoriaID", ReplyAction="http://tempuri.org/ILogic/Alaplap_GetByMemoriaIDResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap>> Alaplap_GetByMemoriaIDAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Billentyuzet_GetByUsbID", ReplyAction="http://tempuri.org/ILogic/Billentyuzet_GetByUsbIDResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet> Billentyuzet_GetByUsbID(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Billentyuzet_GetByUsbID", ReplyAction="http://tempuri.org/ILogic/Billentyuzet_GetByUsbIDResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet>> Billentyuzet_GetByUsbIDAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Billentyuzet_GetByPs", ReplyAction="http://tempuri.org/ILogic/Billentyuzet_GetByPsResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet> Billentyuzet_GetByPs(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Billentyuzet_GetByPs", ReplyAction="http://tempuri.org/ILogic/Billentyuzet_GetByPsResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet>> Billentyuzet_GetByPsAsync(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Eger_GetByUsbID", ReplyAction="http://tempuri.org/ILogic/Eger_GetByUsbIDResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger> Eger_GetByUsbID(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Eger_GetByUsbID", ReplyAction="http://tempuri.org/ILogic/Eger_GetByUsbIDResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger>> Eger_GetByUsbIDAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Eger_GetByPs", ReplyAction="http://tempuri.org/ILogic/Eger_GetByPsResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger> Eger_GetByPs(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Eger_GetByPs", ReplyAction="http://tempuri.org/ILogic/Eger_GetByPsResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger>> Eger_GetByPsAsync(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Hattertar_GetByHattertarTipus", ReplyAction="http://tempuri.org/ILogic/Hattertar_GetByHattertarTipusResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar> Hattertar_GetByHattertarTipus(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Hattertar_GetByHattertarTipus", ReplyAction="http://tempuri.org/ILogic/Hattertar_GetByHattertarTipusResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar>> Hattertar_GetByHattertarTipusAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Hattertar_GetByHattertarCsatolo", ReplyAction="http://tempuri.org/ILogic/Hattertar_GetByHattertarCsatoloResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar> Hattertar_GetByHattertarCsatolo(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Hattertar_GetByHattertarCsatolo", ReplyAction="http://tempuri.org/ILogic/Hattertar_GetByHattertarCsatoloResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar>> Hattertar_GetByHattertarCsatoloAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Memoria_GetByFoglalat", ReplyAction="http://tempuri.org/ILogic/Memoria_GetByFoglalatResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Memoria> Memoria_GetByFoglalat(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Memoria_GetByFoglalat", ReplyAction="http://tempuri.org/ILogic/Memoria_GetByFoglalatResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Memoria>> Memoria_GetByFoglalatAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Monitor_GetByMeret", ReplyAction="http://tempuri.org/ILogic/Monitor_GetByMeretResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor> Monitor_GetByMeret(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Monitor_GetByMeret", ReplyAction="http://tempuri.org/ILogic/Monitor_GetByMeretResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor>> Monitor_GetByMeretAsync(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Monitor_GetByFelbontas", ReplyAction="http://tempuri.org/ILogic/Monitor_GetByFelbontasResponse")]
        ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor> Monitor_GetByFelbontas(int id, int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILogic/Monitor_GetByFelbontas", ReplyAction="http://tempuri.org/ILogic/Monitor_GetByFelbontasResponse")]
        System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor>> Monitor_GetByFelbontasAsync(int id, int pageNumber, int pageSize);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogicChannel : ComputerStore.Client.BusinessLogic.ILogic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogicClient : System.ServiceModel.ClientBase<ComputerStore.Client.BusinessLogic.ILogic>, ComputerStore.Client.BusinessLogic.ILogic {
        
        public LogicClient() {
        }
        
        public LogicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ComputerStore.DTO.Types.ProcesszorFoglalatTipus[] ProcFoglalat_GetKategoriak() {
            return base.Channel.ProcFoglalat_GetKategoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.ProcesszorFoglalatTipus[]> ProcFoglalat_GetKategoriakAsync() {
            return base.Channel.ProcFoglalat_GetKategoriakAsync();
        }
        
        public ComputerStore.DTO.Types.MemoriaTipus[] MemoriaFoglalat_GetKaegoriak() {
            return base.Channel.MemoriaFoglalat_GetKaegoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.MemoriaTipus[]> MemoriaFoglalat_GetKaegoriakAsync() {
            return base.Channel.MemoriaFoglalat_GetKaegoriakAsync();
        }
        
        public ComputerStore.DTO.Types.UsbTipus[] UsbTipus_GetKaegoriak() {
            return base.Channel.UsbTipus_GetKaegoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.UsbTipus[]> UsbTipus_GetKaegoriakAsync() {
            return base.Channel.UsbTipus_GetKaegoriakAsync();
        }
        
        public ComputerStore.DTO.Types.HattertarTipus[] HattertatTipus_GetKaegoriak() {
            return base.Channel.HattertatTipus_GetKaegoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.HattertarTipus[]> HattertatTipus_GetKaegoriakAsync() {
            return base.Channel.HattertatTipus_GetKaegoriakAsync();
        }
        
        public ComputerStore.DTO.Types.HattertarCsatoloTipus[] HattertatCsatoloTipus_GetKaegoriak() {
            return base.Channel.HattertatCsatoloTipus_GetKaegoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.HattertarCsatoloTipus[]> HattertatCsatoloTipus_GetKaegoriakAsync() {
            return base.Channel.HattertatCsatoloTipus_GetKaegoriakAsync();
        }
        
        public ComputerStore.DTO.Types.MonitorFelbontas[] MonitorFelbontasTipus_GetKaegoriak() {
            return base.Channel.MonitorFelbontasTipus_GetKaegoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.MonitorFelbontas[]> MonitorFelbontasTipus_GetKaegoriakAsync() {
            return base.Channel.MonitorFelbontasTipus_GetKaegoriakAsync();
        }
        
        public ComputerStore.DTO.Types.MonitorMeret[] MonitorMeretTipus_GetKaegoriak() {
            return base.Channel.MonitorMeretTipus_GetKaegoriak();
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.MonitorMeret[]> MonitorMeretTipus_GetKaegoriakAsync() {
            return base.Channel.MonitorMeretTipus_GetKaegoriakAsync();
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap> Alaplap_GetByFoglalatID(int id, int pageNumber, int pageSize) {
            return base.Channel.Alaplap_GetByFoglalatID(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap>> Alaplap_GetByFoglalatIDAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Alaplap_GetByFoglalatIDAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap> Alaplap_GetByMemoriaID(int id, int pageNumber, int pageSize) {
            return base.Channel.Alaplap_GetByMemoriaID(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Alaplap>> Alaplap_GetByMemoriaIDAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Alaplap_GetByMemoriaIDAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet> Billentyuzet_GetByUsbID(int id, int pageNumber, int pageSize) {
            return base.Channel.Billentyuzet_GetByUsbID(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet>> Billentyuzet_GetByUsbIDAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Billentyuzet_GetByUsbIDAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet> Billentyuzet_GetByPs(int pageNumber, int pageSize) {
            return base.Channel.Billentyuzet_GetByPs(pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Billentyuzet>> Billentyuzet_GetByPsAsync(int pageNumber, int pageSize) {
            return base.Channel.Billentyuzet_GetByPsAsync(pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger> Eger_GetByUsbID(int id, int pageNumber, int pageSize) {
            return base.Channel.Eger_GetByUsbID(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger>> Eger_GetByUsbIDAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Eger_GetByUsbIDAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger> Eger_GetByPs(int pageNumber, int pageSize) {
            return base.Channel.Eger_GetByPs(pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Eger>> Eger_GetByPsAsync(int pageNumber, int pageSize) {
            return base.Channel.Eger_GetByPsAsync(pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar> Hattertar_GetByHattertarTipus(int id, int pageNumber, int pageSize) {
            return base.Channel.Hattertar_GetByHattertarTipus(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar>> Hattertar_GetByHattertarTipusAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Hattertar_GetByHattertarTipusAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar> Hattertar_GetByHattertarCsatolo(int id, int pageNumber, int pageSize) {
            return base.Channel.Hattertar_GetByHattertarCsatolo(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Hattertar>> Hattertar_GetByHattertarCsatoloAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Hattertar_GetByHattertarCsatoloAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Memoria> Memoria_GetByFoglalat(int id, int pageNumber, int pageSize) {
            return base.Channel.Memoria_GetByFoglalat(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Memoria>> Memoria_GetByFoglalatAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Memoria_GetByFoglalatAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor> Monitor_GetByMeret(int id, int pageNumber, int pageSize) {
            return base.Channel.Monitor_GetByMeret(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor>> Monitor_GetByMeretAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Monitor_GetByMeretAsync(id, pageNumber, pageSize);
        }
        
        public ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor> Monitor_GetByFelbontas(int id, int pageNumber, int pageSize) {
            return base.Channel.Monitor_GetByFelbontas(id, pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<ComputerStore.DTO.Types.PageableList<ComputerStore.DTO.Types.Monitor>> Monitor_GetByFelbontasAsync(int id, int pageNumber, int pageSize) {
            return base.Channel.Monitor_GetByFelbontasAsync(id, pageNumber, pageSize);
        }
    }
}
