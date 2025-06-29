using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayacs
{
    public class MayaSubProcess
    {
        public static (string, string) RunCommand(string filename, string arguments = null, bool useShellExecute = false, ProcessWindowStyle processWindowStyle = ProcessWindowStyle.Hidden, bool createNoWindow = false)
        {
            string stdout = null;
            string stderr = null;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = filename;
            if (arguments != null)
                startInfo.Arguments = arguments;
            startInfo.UseShellExecute = useShellExecute;
            startInfo.CreateNoWindow = createNoWindow;
            startInfo.WindowStyle = processWindowStyle;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    stdout = process.StandardOutput.ReadToEnd();
                    stderr = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return (stdout, stderr);
        }

        public static (string, string) RunCommand(ProcessStartInfo startInfo)
        {
            string stdout = null;
            string stderr = null;

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    stdout = process.StandardOutput.ReadToEnd();
                    stderr = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return (stdout, stderr);
        }

        public static void RunCommandAsync()
        {
            //* Create your Process
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c DIR";

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            process.WaitForExit();
        }

        static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Console.WriteLine(outLine.Data);
        }

    }
}
