using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


/***************************************************************************************************
* CIS 123: Introduction to OOP     |                                                               *
* Murach's C#, 7th Edition         |    Exercise 12-1    Create and use a class                    *
* Chapter 12 Extra Exercises       |    Add a class to an Inventory Maintenance application and    *
* Team 2 Assignment, 28MAY2022     |    then add code to the two forms that use this class.        *
* Patrick McKee & Dominique Tepper |                                                               *
***************************************************************************************************/

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the inventory item.
        private InvItem invItem;


        // Add a method here that gets and returns a new item.
        public InvItem GetNewItem() 
        {
            this.ShowDialog();
            return invItem;
        }


    private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Add code here that creates a new item
                // and closes the form.

                invItem = new InvItem(Convert.ToInt32(txtItemNo.Text), txtDescription.Text, 
                    Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
