using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Queue_Stack_Collection
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Queue<int> queue1 = new Queue<int>(50);
        Queue<int> queue2 = new Queue<int>(50);
        Stack<int> stack1 = new Stack<int>(50);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnQueue_Click(object sender, EventArgs e)
        {
            //add value from textbox
            try
            {
                int value = int.Parse(txtAddValue.Text);
                queue1.Enqueue(value);
                Display(queue1);
                //optional
                txtAddValue.Focus();
                txtAddValue.SelectAll();
            }
            catch (FormatException fe)
            {
                MetroFramework.MetroMessageBox.Show(this, fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw;
            }
        }

        private void btnEnqueueRandVal_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(-999, 1000);
            int y = rand.Next(-999, 1000);
            queue1.Enqueue(x);
            queue2.Enqueue(y);
            Display(queue1);
            Display2(queue2);
        }
        
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            int x = queue1.Dequeue();
            MetroFramework.MetroMessageBox.Show(this,$"item dequeued: {x}", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Display(queue1);
        }
        //helper methods
        private void Display(Queue<int> queue)
        {
            //display in listbox1
            listBox1.Items.Clear();
            foreach (int x in queue)
            {
                listBox1.Items.Add(x);
                //scroll
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }

        private void Display2(Queue<int> queue)
        {
            //display in listbox1
            listBox2.Items.Clear();
            foreach (int x in queue)
            {
                listBox2.Items.Add(x);
                //scroll
                listBox2.TopIndex = listBox2.Items.Count - 1;
            }
        }

        private static Queue<int> SimpleMerge(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> q3 = new Queue<int>();
            if (q1.Count == 0)
                return q2;
            if (q2.Count == 0)
                return q1;

            int size = q1.Count;

            while (q2.Count !=0 || size != 0)
            {
                if (q1.Peek() >= q2.Peek())
                {
                    q3.Enqueue(q1.Dequeue());
                    size--;
                }
                else
                {
                    q3.Enqueue(q2.Dequeue());
                }
            }

            while (q1.Count !=0 || size != 0)
            {
                q3.Enqueue(q1.Dequeue());
                size--;
            }

            return q3;
        }

        private static Queue<int> RemoveOdds(Queue<int> q1)
        {
            foreach (int x in q1)
            {
                if (x % 2 != 0)
                    q1.Dequeue();
            }

            return q1;
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            int x = queue1.Peek();
            MetroFramework.MetroMessageBox.Show(this,$"This item is peeked: {x}", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Display(queue1);
        }

        private void btnEnQueue2_Click(object sender, EventArgs e)
        {
            //add value from textbox
            try
            {
                int value = int.Parse(txtAddValue.Text);
                queue2.Enqueue(value);
                Display2(queue2);
                //optional
                txtAddValue.Focus();
                txtAddValue.SelectAll();
            }
            catch (FormatException fe)
            {
                MetroFramework.MetroMessageBox.Show(this, fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw;
            }
        }

        private void btnDequeue2_Click(object sender, EventArgs e)
        {
            int x = queue2.Dequeue();
            MetroFramework.MetroMessageBox.Show(this,$"item dequeued: {x}", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Display2(queue2);
        }

        private void btnMergeQueues_Click(object sender, EventArgs e)
        {
            SimpleMerge(queue1, queue2);
            Display(queue1);
        }

        private void btnRemoveOdds_Click(object sender, EventArgs e)
        {
            RemoveOdds(queue1);
            Display(queue1);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            //add value from textbox
            try
            {
                int value = int.Parse(txtStackAddValue.Text);
                stack1.Push(value);
                DisplayStack(stack1);
                //optional
                txtStackAddValue.Focus();
                txtStackAddValue.SelectAll();
            }
            catch (FormatException fe)
            {
                MetroFramework.MetroMessageBox.Show(this, fe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw;
            }
        }

        private void DisplayStack(Stack<int> stack)
        {
            //display in listbox1
            listBox3.Items.Clear();
            foreach (int x in stack)
            {
                listBox3.Items.Add(x);
                //scroll
                listBox3.TopIndex = listBox3.Items.Count - 1;
            }
        }

        private void btnPushRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(-999, 1000);
            int y = rand.Next(-999, 1000);
            stack1.Push(x);
            DisplayStack(stack1);
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            //pop a value from the stack
            //the value at the top of the stack is removed and returned
            if (stack1.Count > 0)
            {
                int x = stack1.Pop();
                MetroFramework.MetroMessageBox.Show(this,$"{x} was popped out of the stack", " Success ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                DisplayStack(stack1);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"Illegal Operation: stack is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
 
            }
        }
    }
}
/*
 * exercise: 1
 * 1. add button to use Peek method
 *
 * 2. create a second queue: queue2 and provide buttons to
 *    enqueue and dequeue queue2
 *
 * 3. add button to merge both queues into a single queue: queue3
 *    prefer that you define a method 'SimpleMerge' that take
 *    two queues as parameter and return a merged queue
 *    then from the button call this method and display the new queue
 *
 * 4. write a method 'RemoveOdds' that takes a queue and removes
 *    only the odd values while maintaining the rest in their original sequence
 *    have a button that calls this method and display the queue
 *
 * Excercise: 2
 * define a method that takes two stacks and merge them
 *
 * define a method "convertStackToQueue" that takes a stack and returns a queue
 * with all the items from the stack
 *
 * reverse a stack using another stack
 * remove all the odd value from a stack while maintaining the
 * same original sequence
 */
