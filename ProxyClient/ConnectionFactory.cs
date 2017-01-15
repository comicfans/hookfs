using System.Net
namespace HookFS.Network{

    interface ConnectionFactory{
        Connection CreateConnection(IPAddress dest,int pid,int tid);
    }

}
