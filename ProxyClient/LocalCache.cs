using System.Threading;
using HookFS.Network;
using Microsoft.Win32.SafeHandles;

namespace HookFS{

    class LocalCache{

        public static LocalCache GetInstance(){
            return _instance;
        }

        private LocalCache _instance=new LocalCache();
        private ConnectionFactory _connectionFactory=new ConnectionFactory();

        private ThreadLocal<Connection> _connections=new ThreadLocal<Connection>();

        private Connection GetTLSConnection(){
            if(_connections.Value==null){
                _connections.Value=
            }
        }

        public SafeFileHandle OnCreateFile(
                string lpFileName,
                EFileAccess dwDesiredAccess,
                EFileShare dwShareMode,
                IntPtr lpSecurityAttributes,
                ECreationDisposition dwCreationDisposition,
                EFileAttributes dwFlagsAndAttributes,
                IntPtr hTemplateFile
                ){

        }
    }
}
