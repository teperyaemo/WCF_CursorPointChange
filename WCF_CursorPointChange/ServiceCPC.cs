using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CursorPointChange
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceCPC : IServiceCPC
    {
        List<ServerUser> Users = new List<ServerUser>();
        int NextId = 1;
        public int Connect(string login)
        {
            ServerUser user = new ServerUser
            {
                Id = NextId,
                Login = login,
                OperationContext = OperationContext.Current
            };
            NextId++;
            Users.Add(user);

            return user.Id;
        }

        public void Disconnect(int id)
        {
            var DiconnectedUser = Users.FirstOrDefault(i => i.Id == id);
            if(DiconnectedUser != null)
            {
                Users.Remove(DiconnectedUser);
            }
            
        }

        public void DoWork()
        {
        }

        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
