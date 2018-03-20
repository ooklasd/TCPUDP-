using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CSScriptLibrary;

namespace TCPUDP调试工具
{
    abstract class  script
    {
        public void loadscriptStream(string buffer)
        {
            scriptbuffer = buffer;
        }
        public void loadscriptfile(string file)
        {
            loadscriptStream(File.ReadAllText(file));
        }
        public abstract string run(string func, byte[] content);
       

        protected string scriptbuffer;
        public string scriptSendFile { get; set; }
        public string scriptRecvFile { get; set; }       
    }


    class myCSScript : script
    {
        public override string run(string func, byte[] content)
        {
            object obj = CSScript.Evaluator.LoadCode(scriptbuffer);
            var funcMethod = obj.GetType().GetMethod(func);
            return (string)funcMethod.Invoke(obj,new object[1]{ content});
        }

    }
}
