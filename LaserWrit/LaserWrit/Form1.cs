using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LaserWrit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // TODO Create the file based on the input text box.
            writeFile(inputTextBox.Text.ToUpper());
        }
        private void writeFile(string inText)
        {

            
            //Convert to binary
            Queue<byte> byteQueue = textToBin(inText);
            //Write binary to a file
            writeBinFile(byteQueue);
            //MessageBox.Show(inText);
        }

        // This function takes a text string and converts it to the propper bytes
        // They bytes are stored into a queue for easy processing
        private Queue<byte> textToBin(string text){
            Queue<byte> temp = new Queue<byte>();
            letterLib lib = new letterLib();
            List<byte> btemp;

            //Read in the text and get place it into the queue
            foreach (char let in text)
            {
                // Find the straight on perspective
                btemp = lib.diction[let];
                // modify results for perspective
                foreach (byte i in btemp)
                {
                    temp.Enqueue(i);
                }

                

            }
                // modify restuts for other things.
            


            return temp;

        }

        // This function takes a binary queue file and writes it to a .dat
        private void writeBinFile(Queue<byte> byteQueue){
            FileStream writeStream ;
            try
            {
                writeStream = new FileStream("C:\\Temp\\laser.dat", FileMode.Create);
                BinaryWriter writeBinay = new BinaryWriter(writeStream);
                while(byteQueue.Count > 0){
                    writeBinay.Write(byteQueue.Dequeue());
                }
                writeBinay.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.ToString());
            }
        }


        
            
    }
   
}
