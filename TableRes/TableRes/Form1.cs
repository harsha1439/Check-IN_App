using System;
using System.IO;
using System.Windows.Forms;

namespace TableRes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //When User clicks Reservation Button
        private void ResButton1_Click(object sender, EventArgs e)
        {


            //check input
            int tempID;
            if (int.TryParse(textBox1.Text, out tempID))
            {
                tempID = int.Parse(textBox1.Text);
                CheckoutButton1.Visible = false;
                LayoutGroupBox.Visible = true;
            }
            else
            {
                MessageBox.Show("please enter a valid ID number");
            }




        }


        public bool buttonwasclicked = false;
        private bool button2wasclicked = false;
        private bool button3wasclicked = false;
        private bool button4wasclicked = false;
        private bool button5wasclicked = false;
        private bool button6wasclicked = false;
        private bool button7wasclicked = false;
        private bool button8wasclicked = false;
        private bool button9wasclicked = false;
        private bool button10wasclicked = false;
        private bool button11wasclicked = false;
        private bool button12wasclicked = false;
        private bool button13wasclicked = false;
        private bool button14wasclicked = false;
        private bool button15wasclicked = false;
        private bool button16wasclicked = false;
        private bool button17wasclicked = false;
        private bool button18wasclicked = false;
        private bool button19wasclicked = false;
        private bool button20wasclicked = false;
        private bool button21wasclicked = false;
        private bool button22wasclicked = false;
        private bool button23wasclicked = false;
        private bool button24wasclicked = false;



        private void Seat1_Click(object sender, EventArgs e)
        {
            buttonwasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat1.Text;
        }

        private void Seat2_Click(object sender, EventArgs e)
        {
            button2wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat2.Text;
        }

        private void Seat3_Click(object sender, EventArgs e)
        {
            button3wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat3.Text;
        }

        private void Seat4_Click(object sender, EventArgs e)
        {
            button4wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat4.Text;
        }
        private void Seat5_Click(object sender, EventArgs e)
        {
            button5wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat5.Text;
        }

        //When Reservation Yes button is clicked
        private void ResYes_Click(object sender, EventArgs e)
        {
            int[] inputList = new int[10];
            inputID(inputList);
            int[] inputSeatList = new int[10];
            inputseat(inputSeatList);

            if (Seat1.Text == "Seat 1" && buttonwasclicked)
            {
                Seat1.Enabled = false;

            }
            else if (Seat2.Text == "Seat 2" && button2wasclicked)
            {
                Seat2.Enabled = false;

            }
            else if (Seat3.Text == "Seat 3" && button3wasclicked)
            {
                Seat3.Enabled = false;

            }
            else if (Seat4.Text == "Seat 4" && button4wasclicked)
            {
                Seat4.Enabled = false;

            }
            else if (Seat5.Text == "Seat 5" && button5wasclicked)
            {
                Seat5.Enabled = false;

            }
            else if (Seat6.Text == "Seat 6" && button6wasclicked)
            {
                Seat6.Enabled = false;

            }
            else if (Seat7.Text == "Seat 7" && button7wasclicked)
            {
                Seat7.Enabled = false;

            }
            else if (Seat8.Text == "Seat 8" && button8wasclicked)
            {
                Seat8.Enabled = false;

            }
            else if (Seat9.Text == "Seat 9" && button9wasclicked)
            {
                Seat9.Enabled = false;

            }
            else if (Seat10.Text == "Seat 10" && button10wasclicked)
            {
                Seat10.Enabled = false;

            }
            else if (Seat11.Text == "Seat 11" && button11wasclicked)
            {
                Seat11.Enabled = false;

            }
            else if (Seat12.Text == "Seat 12" && button12wasclicked)
            {
                Seat12.Enabled = false;

            }
            else if (Seat13.Text == "Seat 13" && button13wasclicked)
            {
                Seat13.Enabled = false;

            }
            else if (Seat14.Text == "Seat 14" && button14wasclicked)
            {
                Seat14.Enabled = false;

            }
            else if (Seat15.Text == "Seat 15" && button15wasclicked)
            {
                Seat15.Enabled = false;

            }
            else if (Seat16.Text == "Seat 16" && button16wasclicked)
            {
                Seat16.Enabled = false;

            }
            else if (Seat17.Text == "Seat 17" && button17wasclicked)
            {
                Seat17.Enabled = false;

            }
            else if (Seat18.Text == "Seat 18" && button18wasclicked)
            {
                Seat18.Enabled = false;

            }
            else if (Seat19.Text == "Seat 19" && button19wasclicked)
            {
                Seat19.Enabled = false;

            }
            else if (Seat20.Text == "Seat 20" && button20wasclicked)
            {
                Seat20.Enabled = false;

            }
            else if (Seat21.Text == "Seat 21" && button21wasclicked)
            {
                Seat21.Enabled = false;

            }
            else if (Seat22.Text == "Seat 22" && button22wasclicked)
            {
                Seat22.Enabled = false;

            }
            else if (Seat23.Text == "Seat 23" && button23wasclicked)
            {
                Seat23.Enabled = false;

            }
            else if (Seat24.Text == "Seat 24" && button24wasclicked)
            {
                Seat24.Enabled = false;

            }
            else
            {
                MessageBox.Show("please select atleat one seat");
            }



            ConfGroupBox1.Visible = true;
            //Create relationship between SeatLabel.Text and zID
            ConfLabel.Text = textBox1.Text + " has reserved " + SeatLabel.Text;
            {

            }
        }





        private void ResReset_Click(object sender, EventArgs e)
        {
            buttonwasclicked = false;
            button2wasclicked = false;
            button3wasclicked = false;
            button4wasclicked = false;
            button5wasclicked = false;
            button6wasclicked = false;
            button7wasclicked = false;
            button9wasclicked = false;
            button10wasclicked = false;
            button11wasclicked = false;
            button12wasclicked = false;
            button13wasclicked = false;
            button14wasclicked = false;
            button15wasclicked = false;
            button16wasclicked = false;
            button17wasclicked = false;
            button18wasclicked = false;
            button19wasclicked = false;
            button20wasclicked = false;
            button21wasclicked = false;
            button22wasclicked = false;
            button23wasclicked = false;
            button24wasclicked = false;

            ConfGroupBox1.Visible = false;
            ResGroupBox.Visible = false;
            LayoutGroupBox.Visible = false;
            CheckoutButton1.Visible = true;
            textBox1.Text = "";
        }

        private void CheckoutButton1_Click(object sender, EventArgs e)
        {
            ResButton1.Visible = false;


            string[] read = new string[100];
            readtext(read);




            CheckoutGroupBox1.Visible = true;
            //Create step that clears relationship between zID and Seat#
            CheckoutLabel.Text = textBox1.Text + " Has been checked out.";
        }

        private void CheReset_Click(object sender, EventArgs e)
        {
            CheckoutGroupBox1.Visible = false;
            ResButton1.Visible = true;
            textBox1.Text = "";

        }
        //Write seat numbers into textbox
        private void inputseat(int[] inpuSeatList)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("..\\..\\IDs.txt");
                if (Seat1.Text == "Seat 1" && buttonwasclicked)
                {
                    outputFile.WriteLine(Seat1.Text);
                }
                else if (Seat2.Text == "Seat 2" && button2wasclicked)
                {
                    outputFile.WriteLine(Seat2.Text);
                }
                else if (Seat3.Text == "Seat 3" && button3wasclicked)
                {
                    outputFile.WriteLine(Seat3.Text);
                }
                else if (Seat4.Text == "Seat 4" && button4wasclicked)
                {
                    outputFile.WriteLine(Seat4.Text);
                }



                else if (Seat5.Text == "Seat 5" && button5wasclicked)
                {
                    outputFile.WriteLine(Seat5.Text);
                }
                else if (Seat6.Text == "Seat 6" && button6wasclicked)
                {
                    outputFile.WriteLine(Seat6.Text);
                }
                else if (Seat7.Text == "Seat 7" && button7wasclicked)
                {
                    outputFile.WriteLine(Seat7.Text);
                }
                else if (Seat8.Text == "Seat 8" && button8wasclicked)
                {
                    outputFile.WriteLine(Seat8.Text);
                }
                else if (Seat9.Text == "Seat 9" && button9wasclicked)
                {
                    outputFile.WriteLine(Seat9.Text);
                }
                else if (Seat10.Text == "Seat 10" && button10wasclicked)
                {
                    outputFile.WriteLine(Seat10.Text);
                }
                else if (Seat11.Text == "Seat 11" && button11wasclicked)
                {
                    outputFile.WriteLine(Seat11.Text);
                }
                else if (Seat12.Text == "Seat 12" && button12wasclicked)
                {
                    outputFile.WriteLine(Seat12.Text);
                }
                else if (Seat13.Text == "Seat 13" && button13wasclicked)
                {
                    outputFile.WriteLine(Seat13.Text);
                }
                else if (Seat14.Text == "Seat 14" && button14wasclicked)
                {
                    outputFile.WriteLine(Seat14.Text);
                }
                else if (Seat15.Text == "Seat 15" && button15wasclicked)
                {
                    outputFile.WriteLine(Seat15.Text);
                }
                else if (Seat16.Text == "Seat 16" && button16wasclicked)
                {
                    outputFile.WriteLine(Seat16.Text);
                }
                else if (Seat17.Text == "Seat 17" && button17wasclicked)
                {
                    outputFile.WriteLine(Seat17.Text);
                }
                else if (Seat18.Text == "Seat 18" && button18wasclicked)
                {
                    outputFile.WriteLine(Seat18.Text);

                }
                else if (Seat19.Text == "Seat 19" && button19wasclicked)
                {
                    outputFile.WriteLine(Seat19.Text);
                }
                else if (Seat20.Text == "Seat 20" && button20wasclicked)
                {
                    outputFile.WriteLine(Seat20.Text);
                }
                else if (Seat21.Text == "Seat 21" && button21wasclicked)
                {
                    outputFile.WriteLine(Seat21.Text);
                }
                else if (Seat22.Text == "Seat 22" && button22wasclicked)
                {
                    outputFile.WriteLine(Seat22.Text);
                }
                else if (Seat23.Text == "Seat 23" && button23wasclicked)
                {
                    outputFile.WriteLine(Seat23.Text);
                }
                else if (Seat24.Text == "Seat 24" && button24wasclicked)
                {
                    outputFile.WriteLine(Seat24.Text);
                }



                outputFile.Close();

                textBox1.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //Method to Read values from IDs text file
        private void readtext(string[] read)
        {
            try
            {
                string[] readText = File.ReadAllLines("..\\..\\IDs.txt");

                for (int startScan = 0; startScan < readText.Length; startScan++)
                {
                    for (int index = startScan + 1; index < readText.Length; index++)
                    {
                        if (readText[index] == "Seat 1" && readText[startScan] == textBox1.Text)
                        {
                            Seat1.Enabled = true;

                            break;

                        }
                        else if (readText[index] == "Seat 2" && readText[startScan] == textBox1.Text)
                        {
                            Seat2.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 3" && readText[startScan] == textBox1.Text)
                        {
                            Seat3.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 4" && readText[startScan] == textBox1.Text)
                        {
                            Seat4.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 5" && readText[startScan] == textBox1.Text)
                        {
                            Seat5.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 6" && readText[startScan] == textBox1.Text)
                        {
                            Seat6.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 7" && readText[startScan] == textBox1.Text)
                        {
                            Seat7.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 8" && readText[startScan] == textBox1.Text)
                        {
                            Seat8.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 9" && readText[startScan] == textBox1.Text)
                        {
                            Seat9.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 10" && readText[startScan] == textBox1.Text)
                        {
                            Seat10.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 11" && readText[startScan] == textBox1.Text)
                        {
                            Seat11.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 12" && readText[startScan] == textBox1.Text)
                        {
                            Seat12.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 13" && readText[startScan] == textBox1.Text)
                        {
                            Seat13.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 14" && readText[startScan] == textBox1.Text)
                        {
                            Seat14.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 15" && readText[startScan] == textBox1.Text)
                        {
                            Seat15.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 16" && readText[startScan] == textBox1.Text)
                        {
                            Seat16.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 17" && readText[startScan] == textBox1.Text)
                        {
                            Seat17.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 18" && readText[startScan] == textBox1.Text)
                        {
                            Seat18.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 19" && readText[startScan] == textBox1.Text)
                        {
                            Seat19.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 20" && readText[startScan] == textBox1.Text)
                        {
                            Seat20.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 21" && readText[startScan] == textBox1.Text)
                        {
                            Seat21.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 22" && readText[startScan] == textBox1.Text)
                        {
                            Seat22.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 23" && readText[startScan] == textBox1.Text)
                        {
                            Seat23.Enabled = true;
                            break;

                        }
                        else if (readText[index] == "Seat 24" && readText[startScan] == textBox1.Text)
                        {
                            Seat24.Enabled = true;
                            break;

                        }


                    }
                }


            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Method to write ID Values from text box
        private void inputID(int[] inputList)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("..\\..\\IDs.txt");
                outputFile.WriteLine(textBox1.Text);
                outputFile.Close();

                textBox1.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ResNo_Click(object sender, EventArgs e)
        {
            LayoutGroupBox.Visible = true;
            ResGroupBox.Visible = false;
        }

        private void Seat6_Click_1(object sender, EventArgs e)
        {
            button6wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat6.Text;
        }

        private void Seat7_Click(object sender, EventArgs e)
        {
            button7wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat7.Text;
        }

        private void Seat8_Click(object sender, EventArgs e)
        {
            button8wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat8.Text;
        }

        private void Seat9_Click(object sender, EventArgs e)
        {
            button9wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat9.Text;
        }

        private void Seat10_Click(object sender, EventArgs e)
        {
            button10wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat10.Text;
        }

        private void Seat11_Click(object sender, EventArgs e)
        {
            button11wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat11.Text;
        }

        private void Seat12_Click(object sender, EventArgs e)
        {
            button12wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat12.Text;
        }

        private void Seat13_Click(object sender, EventArgs e)
        {
            button13wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat13.Text;
        }

        private void Seat14_Click(object sender, EventArgs e)
        {
            button14wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat14.Text;
        }

        private void Seat15_Click(object sender, EventArgs e)
        {
            button15wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat15.Text;
        }

        private void Seat16_Click(object sender, EventArgs e)
        {
            button16wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat16.Text;
        }

        private void Seat17_Click(object sender, EventArgs e)
        {
            button17wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat17.Text;
        }

        private void Seat18_Click(object sender, EventArgs e)
        {
            button18wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat18.Text;
        }

        private void Seat19_Click(object sender, EventArgs e)
        {
            button19wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat19.Text;
        }

        private void Seat20_Click(object sender, EventArgs e)
        {
            button20wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat20.Text;
        }

        private void Seat21_Click(object sender, EventArgs e)
        {
            button21wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat21.Text;
        }

        private void Seat22_Click(object sender, EventArgs e)
        {
            button22wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat22.Text;
        }

        private void Seat23_Click(object sender, EventArgs e)
        {
            button23wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat23.Text;
        }

        private void Seat24_Click(object sender, EventArgs e)
        {
            button24wasclicked = true;
            ResGroupBox.Visible = true;
            SeatLabel.Text = Seat24.Text;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            this.Close();
            StreamWriter strm = File.CreateText("..\\..\\IDs.txt");
            strm.Flush();
            strm.Close();

        }
    }

}
