using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriorityy
{
    public partial class frmTrackThread : Form
    {
        private Thread threadA;
        private Thread threadB;
        private Thread threadC;
        private Thread threadD;

        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            threadA = new Thread(new ThreadStart(MyThreadClass.Thread1)) { Name = "Thread A" };
            threadB = new Thread(new ThreadStart(MyThreadClass.Thread2)) { Name = "Thread B" };
            threadC = new Thread(new ThreadStart(MyThreadClass.Thread1)) { Name = "Thread C" };
            threadD = new Thread(new ThreadStart(MyThreadClass.Thread2)) { Name = "Thread D" };

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;


            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();
            Console.WriteLine("-End of Thread");
            UpdateLabel();
        }
        private void UpdateLabel()
        {

            this.Invoke((MethodInvoker)delegate
            {
                labelStatus.Text = "-End Of Thread-";
            });
        }
    }
}