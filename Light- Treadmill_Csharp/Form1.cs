using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Treadmill_Csharp
{
    public partial class Dashboard : Form
    {
        // Creating variables
        int hrs, min, secs;
        string weight_unit, speed_unit, height_unit;
        double speed_val, height_val, weight_val;
        double weight, height, speed, seconds;


        public Dashboard()
        {
            InitializeComponent();
            secs = min = hrs = 0;
            seconds = 0.0;
            speed_val = height_val = weight_val = weight = height = speed = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Accept only numbers, dot, enter and tab
        private void speed_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8 && chr != 9 && chr != '.')
            {
                e.Handled = true;
            }
        }

        // Passing values to variables
        private void weight_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Convert inputs to float values
                weight_val = float.Parse(weight_txt.Text);
            }
            catch
            {
                // Show error message if enter more than one dot
                // Not to show error message when textbox empty
                if (weight_txt.Text != "" && weight_txt.Text != ".")
                {
                    MessageBox.Show("Enter one dot only", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }

        private void speed_txt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                // Same as above
                speed_val = float.Parse(speed_txt.Text);
            }
            catch
            {
                if (speed_txt.Text != "" && speed_txt.Text!=".")
                {
                    MessageBox.Show("Enter one dot only", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
                
            }

        }

        private void height_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                height_val = float.Parse(height_txt.Text);
            }
            catch
            {
                if (height_txt.Text != "" && height_txt.Text != ".")
                {
                    MessageBox.Show("Enter one dot only", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                }
            }
        }
        // Assign units
        private void ms_rdbtn_Click(object sender, EventArgs e)
        {
            speed_unit = ms_rdbtn.Text.ToString();

            // when speed is too high show warning, and ask for reduce speed
            // World record men: 10.43 m/s , women: 9.53 m/s 
            try
            {
                if (speed_val > 10.0)
                {
                    DialogResult confirm = MessageBox.Show("Your speed is too high." + "\n" + "Reduce speed.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        speed_txt.Text = "10";
                    }
                    else if (confirm == DialogResult.Cancel)
                    { }
                }
            }
            catch
            {

            }
        }

        private void km_rdbtn_Click(object sender, EventArgs e)
        {
            speed_unit = km_rdbtn.Text.ToString();

            // when speed is too high show warning, and ask for reduce speed
            // World record men: 37.55 kmph , women: 34.31 kmph
            try
            {
                if (speed_val > 36.0)
                {
                    DialogResult confirm = MessageBox.Show("Your speed is too high." + "\n" + "Reduce speed.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        speed_txt.Text = "36";
                    }
                    else if (confirm == DialogResult.Cancel)
                    { }
                }
            }
            catch
            {

            }
        }

        private void kg_rdbtn_Click(object sender, EventArgs e)
        {
            weight_unit = kg_rdbtn.Text.ToString();

            // when weight is too high show warning and clear entry
            // World record man: 442 kg
            try
            {
                if (weight_val > 443.0)
                {
                    DialogResult confirm = MessageBox.Show("Invalid weight." + "\n" + "Enter correct value.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        weight_txt.Clear();
                    }
                    else
                    { }
                }
            }
            catch
            {

            }
        }

        private void lb_rdbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cm_rdbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lb_rdbtn_Click(object sender, EventArgs e)
        {

            weight_unit = lb_rdbtn.Text.ToString();

            // when weight is too high show warning and clear entry
            // World record man: 974 lb
            try
            {
                if (weight_val > 974.0)
                {
                    DialogResult confirm = MessageBox.Show("Invalid weight." + "\n" + "Enter correct value.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        weight_txt.Clear();
                    }
                    else
                    { }
                }
            }
            catch
            {

            }
        }

        private void cm_rdbtn_Click(object sender, EventArgs e)
        {
            height_unit = cm_rdbtn.Text.ToString();

            // when heiht is too large show warning and clear input
            // World record 251 cm
            try
            {
                if (height_val > 251.0)
                {
                    DialogResult confirm = MessageBox.Show("Invalid height."+"\n"+"Enter a correct value.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        height_txt.Clear();
                    }
                    else
                    { }
                }
            }
            catch
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void m_rdbtn_Click(object sender, EventArgs e)
        {
            height_unit = m_rdbtn.Text.ToString();

            // when heiht is too large show warning and clear input
            // World record 2.51 m
            try
            {
                if (height_val > 2.51)
                {
                    DialogResult confirm = MessageBox.Show("Invalid height." + "\n" + "Enter a correct value.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        height_txt.Clear();
                    }
                    else
                    { }
                }
            }
            catch
            {

            }
        }


        private void in_rdbtn_Click(object sender, EventArgs e)
        {
            height_unit = in_rdbtn.Text.ToString();

            // when heiht is too large show warning and clear input
            // World record 98.82 in
            try
            {
                if (height_val > 99.0)
                {
                    DialogResult confirm = MessageBox.Show("Invalid height." + "\n" + "Enter a correct value.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.OK)
                    {
                        height_txt.Clear();
                    }
                    else
                    { }
                }
            }
            catch
            {

            }

        }
        // End of assign units

        private void pause_btn_Click(object sender, EventArgs e)
        {
            // Stop the loops
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Show real time
            real_time_txt.Text = DateTime.Now.ToLongTimeString();
            real_date_txt.Text = DateTime.Now.ToShortDateString();
        }

        private void real_date_txt_TextChanged(object sender, EventArgs e)
        {

        }

        //float time_dif;
        private void start_btn_Click(object sender, EventArgs e)
        {
            // Start the timer
            timer2.Start();
            timer3.Start();
            timer4.Start();


            // Converting values
            if (weight_unit == "kg")
            {
                weight = weight_val;
            }
            else if (weight_unit == "lb")
            {
                weight = weight_val * 0.4536;
            }
            if (height_unit == "cm")
            {
                height = height_val * 0.01;
            }
            else if (height_unit == "m")
            {
                height = height_val;
            }
            else if (height_unit == "in")
            {
                height = height_val * 0.0254;
            }
            if (speed_unit == "m/s")
            {
                speed = speed_val;
            }
            else if (speed_unit == "kmph")
            {
                speed = speed_val * 0.278;
            }

            // Calculate BMI and show
            double bmi = weight / (height * height);
            bmi_txt.Text = Math.Round(bmi, 2, MidpointRounding.ToEven).ToString();
        }


        private void stop_btn_Click(object sender, EventArgs e)
        {
            // Stop the timers(loops)
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

            // clear the values
            secs = min = hrs = 0;
            weight = height = speed = seconds = speed_val = height_val = weight_val = 0.0;


            // Clear the inputs
            speed_txt.Clear();
            weight_txt.Clear();
            height_txt.Clear();

        }

        // Method for output intigers as to digits
        private string appendzero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            secs++;
            // Assign seconds for further calculations
            if (secs > 59)
            {
                min++;
                secs = 0;
            }
            if (min > 59)
            {
                hrs++;
                min = 0;
            }

            // Show runtime in  'time_txt' text box
            int secs_convrt = Convert.ToInt32(secs);
            time_txt.Text = (appendzero(hrs) + ':'+ appendzero(min) + ':'+ appendzero(secs_convrt));

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Timer for calculations
            seconds = seconds + 0.5;
        }

        // The loop for real time data showing
        private void timer4_Tick(object sender, EventArgs e)
        {

            try
            {
                // Function to calculate distance, then show
                double distance = seconds * speed;
                dist_txt.Text = Math.Round(distance, 2, MidpointRounding.ToEven).ToString();


                // Function to calculate steps, then show
                double steps = (seconds * speed * 2) / (height * 0.413);
                int step_count = Convert.ToInt32(steps);
                steps_txt.Text = step_count.ToString();


                // Function to calculate calories, then show
                double caloriespermin = ((0.035 * weight) + ((speed * speed) / (height * 0.01)) * 0.029 * weight);
                double calories = caloriespermin * (seconds / 60);
                calory_txt.Text = Math.Round(calories, 2, MidpointRounding.ToEven).ToString();

            }
            catch
            {
                // When start without adding all data stop the loops and show message
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                MessageBox.Show("Enter all values and select units.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
