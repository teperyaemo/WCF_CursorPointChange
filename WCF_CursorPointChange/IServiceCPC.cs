using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CursorPointChange
{
    [ServiceContract(CallbackContract =typeof(IServerCPCCallBack))]
    public interface IServiceCPC
    {
        [OperationContract]
        int Connect(string login);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message, int id);

        [OperationContract]
        DataTable GetData();

        [OperationContract]
        string InsertData(string description);
    }

    public interface IServerCPCCallBack
    {
        [OperationContract(IsOneWay =true)]
        void MessageCallBack(string message);
    }
}
