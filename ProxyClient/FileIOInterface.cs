using System;
using Microsoft.Win32.SafeHandles;
using HookFS;

namespace HookFS.Client 
{

    public class Report{
        static public void Unsupported(){}
        static public SafeFileHandle UnsupportedHandle(){
            Unsupported();
            return new SafeFileHandle(IntPtr.Zero,false);
        }
    }

    public class FileIOInterface : MarshalByRefObject
    {

        public void OnException(Exception ex){
        }

        public SafeFileHandle OnCreateFile(
                string lpFileName,
                EFileAccess dwDesiredAccess,
                EFileShare dwShareMode,
                IntPtr lpSecurityAttributes,
                ECreationDisposition dwCreationDisposition,
                EFileAttributes dwFlagsAndAttributes,
                IntPtr hTemplateFile)
        {

            if (lpSecurityAttributes!=IntPtr.Zero){
                return Report.UnsupportedHandle();
            }

            if (hTemplateFile!=IntPtr.Zero)
            {
                return Report.UnsupportedHandle();
            }

            return LocalCache.GetInstance().OnCreateFile(
                    lpFileName,dwDesiredAccess,dwShareMode,
                    lpSecurityAttributes,dwCreationDisposition,
                    dwFlagsAndAttributes,hTemplateFile
                    );
        }
    }
}
