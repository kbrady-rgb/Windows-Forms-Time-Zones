using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Time Zone
* Author      : Kabrina Brady
* Created     : 9/15/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User selects a city from the list, checks CheckBox, clicks OK, and time zone of that city is displayed
*               Input:  Mouse clicks or keyboard
*               Output: Time zone
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace ControlsAndCompoundConditionBrady
{
    public partial class TimeZone : Form
    {
        public TimeZone()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (submitCheckBox.Checked == true) //runs program if CheckBox is checked
            {
                string city; //holds name of a city
                if (cityListBox.SelectedIndex != -1)
                {
                    //get selected item
                    city = cityListBox.SelectedItem.ToString();

                    //determine time zone
                    if (cityListBox.SelectedItem == "Honolulu")
                    {
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                    }
                    else if (cityListBox.SelectedItem == "San Francisco")
                    {
                        timeZoneLabel.Text = "Pacific";
                    }
                    else if (cityListBox.SelectedItem == "Denver")
                    {
                        timeZoneLabel.Text = "Mountain";
                    }
                    else if (cityListBox.SelectedItem == "New York")
                    {
                        timeZoneLabel.Text = "Eastern";
                    }
                    else if (cityListBox.SelectedItem == "Minneapolis")
                    {
                        timeZoneLabel.Text = "Central";
                    }
                }
                else
                {
                    //no city was selected
                    MessageBox.Show("Select a city.");
                }
            }
            else
            {
                MessageBox.Show("Please check the box."); //prompts the user to check the box if hasn't been checked
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}
