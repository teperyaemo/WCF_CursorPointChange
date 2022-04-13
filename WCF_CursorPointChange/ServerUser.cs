using System.ServiceModel;

namespace WCF_CursorPointChange
{
    internal class ServerUser
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public bool IsAdmin { get; set; }

        public OperationContext OperationContext { get; set; }
    }
}
