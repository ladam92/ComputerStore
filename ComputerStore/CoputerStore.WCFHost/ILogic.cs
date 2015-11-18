using ComputerStore.DTO.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoputerStore.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILogic
    {
        [OperationContract]
        List<ProcesszorFoglalatTipus> ProcFoglalat_GetKategoriak();

        [OperationContract]
        List<MemoriaTipus> MemoriaFoglalat_GetKaegoriak();

        [OperationContract]
        List<UsbTipus> UsbTipus_GetKaegoriak();

        [OperationContract]
        List<HattertarTipus> HattertatTipus_GetKaegoriak();

        [OperationContract]
        List<HattertarCsatoloTipus> HattertatCsatoloTipus_GetKaegoriak();

        [OperationContract]
        List<MonitorFelbontas> MonitorFelbontasTipus_GetKaegoriak();

        [OperationContract]
        List<MonitorMeret> MonitorMeretTipus_GetKaegoriak();

        [OperationContract]
        PageableList<Alaplap> Alaplap_GetByFoglalatID(int id, int pageNumber, int pageSize);
    }
}
