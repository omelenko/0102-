using System.Diagnostics;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<Process> pr = new List<Process>();
        public static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public static int alarmCounter = 1;
        public static bool exitFlag = false;
        public static string selectedProcessName = "";
        const Int32 INVALID_HANDLE_VALUE = -1;
        const int TH32CS_SNAPPROCESS = 0x00000002;
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);
        [DllImport("kernel32", EntryPoint = "Process32FirstW", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool Process32First(IntPtr hSnapshot, IntPtr lppe);
        [DllImport("kernel32", EntryPoint = "Process32Next")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool Process32Next(IntPtr hSnapshot, IntPtr lppe);
        [DllImport("kernel32", EntryPoint = "CloseHandle")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr handle);
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            pr.Clear();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            IntPtr snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
            if (snapshot.ToInt32() != INVALID_HANDLE_VALUE)
            {
                PROCESSENTRY32 processEntry = new PROCESSENTRY32();
                processEntry.dwSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(PROCESSENTRY32));
                IntPtr p32IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(processEntry));
                Marshal.StructureToPtr(processEntry, p32IntPtr, false);
                if (Process32First(snapshot, p32IntPtr))
                {
                    do
                    {
                        PROCESSENTRY32 a = (PROCESSENTRY32)Marshal.PtrToStructure(p32IntPtr, typeof(PROCESSENTRY32));
                        string name;
                        try
                        {
                            using (var p = Process.GetProcessById((int)a.th32ProcessID)) { name = p.ProcessName; pr.Add(p); }
                        }
                        catch
                        {
                            name = a.szExeFile;
                        }
                        listBox1.Items.Add(name);
                    } while (Process32Next(snapshot, p32IntPtr));
                }
                CloseHandle(snapshot);
            }
            else
            {
                //std::cout << "Не вдалося отримати список процесів!\n";
            }
        }

        public void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            UpdateList();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            myTimer.Interval = 5000;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Start();
            IntPtr snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
            if (snapshot.ToInt32() != INVALID_HANDLE_VALUE)
            {
                PROCESSENTRY32 processEntry = new PROCESSENTRY32();
                processEntry.dwSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(PROCESSENTRY32));
                IntPtr p32IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(processEntry));
                Marshal.StructureToPtr(processEntry, p32IntPtr, false);
                if (Process32First(snapshot, p32IntPtr))
                {
                    do
                    {
                        PROCESSENTRY32 a = (PROCESSENTRY32)Marshal.PtrToStructure(p32IntPtr, typeof(PROCESSENTRY32));
                        string name;
                        try
                        {
                            using (var p = Process.GetProcessById((int)a.th32ProcessID)) { name = p.ProcessName; pr.Add(p); }
                        }
                        catch
                        {
                            name = a.szExeFile;
                        }
                        listBox1.Items.Add(name);
                    } while (Process32Next(snapshot, p32IntPtr));
                }
                CloseHandle(snapshot);
            }
            else
            {
                //std::cout << "Не вдалося отримати список процесів!\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] h = Process.GetProcessesByName(selectedProcessName);
            foreach (Process a in h)
            {
                a.Kill();
            }
            UpdateList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedProcessName = listBox1.Items[listBox1.SelectedIndex].ToString();
                Process[] h = Process.GetProcessesByName(selectedProcessName);
                label7.Text = h[0].Id.ToString();
                label8.Text = h[0].StartTime.ToString();
                label9.Text = (DateTime.Now - h[0].StartTime).ToString();
                label10.Text = h[0].Threads.Count.ToString();
                label11.Text = h.Length.ToString();
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}