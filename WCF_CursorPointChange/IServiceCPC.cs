using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CursorPointChange
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IServiceCPC" в коде и файле конфигурации.
    [ServiceContract(CallbackContract =typeof(IServerCPCCallBack))]
    public interface IServiceCPC
    {
        [OperationContract]
        int Connect(string login);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }

    public interface IServerCPCCallBack
    {
        [OperationContract]
        void MessageCallBack(string message);
    }
}
