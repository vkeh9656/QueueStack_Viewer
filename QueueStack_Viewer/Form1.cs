using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueStack_Viewer
{
    public partial class Form1 : Form
    {

        Queue<int> _Queue = new Queue<int>(6);
        Stack<int> _Stack = new Stack<int>(6);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataIn_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iData = rd.Next(1, 101); // 1 ~ 100까지 숫자 중 랜덤하게 추출

            // Queue에 data 입력
            if(_Queue.Count < 6)
            {
                _Queue.Enqueue(iData); // Queue에 데이터 삽입 : Enqueue
            }

            // Stack에 data 입력
            if(_Stack.Count < 6)
            {
                _Stack.Push(iData);  // Stack 데이터 삽입 : Push
            }
        }


        private void QueueDataDisplay()
        {
            int[] iArray = _Queue.ToArray();

            Array.Resize(ref iArray, 6);

            lblQueue0.Text = iArray[0].ToString();
            lblQueue1.Text = iArray[1].ToString();
            lblQueue2.Text = iArray[2].ToString();
            lblQueue3.Text = iArray[3].ToString();
            lblQueue4.Text = iArray[4].ToString();
            lblQueue5.Text = iArray[5].ToString();
        }

        private void StackDataDisplay()
        {
            int[] iArray = _Stack.ToArray();

            Array.Resize(ref iArray, 6);

            lblStack0.Text = iArray[0].ToString();
            lblStack1.Text = iArray[1].ToString();
            lblStack2.Text = iArray[2].ToString();
            lblStack3.Text = iArray[3].ToString();
            lblStack4.Text = iArray[4].ToString();
            lblStack5.Text = iArray[5].ToString();
        }
    }
}
